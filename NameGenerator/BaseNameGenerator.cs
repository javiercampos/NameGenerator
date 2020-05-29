using System;

namespace NameGenerator
{
    public abstract class BaseNameGenerator<TMale, TFemale, TLastName> : IRandomNameGenerator
    where TMale: INameList
    where TFemale: INameList
    where TLastName: INameList
    {
        private readonly TMale _maleList;
        private readonly TFemale _femaleList;
        private readonly TLastName _lastNameList;
        private readonly IRandomGenerator _randomGenerator;

        protected BaseNameGenerator(TMale maleList, TFemale femaleList, TLastName lastNameList, IRandomGenerator randomGenerator)
        {
            _maleList = maleList;
            _femaleList = femaleList;
            _lastNameList = lastNameList;
            _randomGenerator = randomGenerator;
        }


        public virtual string GetFullName(decimal maleProbability = 50)
        {
            return string.Join(" ", GetFirstName(maleProbability), GetLastName());
        }

        public virtual string GetFirstName(decimal maleProbability = 50)
        {
            return GetRandomName(maleProbability, _maleList, _femaleList);
        }

        public virtual string GetLastName()
        {
            return GetRandomName(_lastNameList);
        }

        public string GetRandomName(string[] names)
        {
            return names[_randomGenerator.NextRandomInt() % names.Length];
        }
        public string GetRandomName(INameList nameList)
        {
            return nameList.Names[_randomGenerator.NextRandomInt() % nameList.Names.Length];
        }
        public string GetRandomName(decimal maleProbabilityPercent, INameList nameListMale, INameList nameListFemale)
        {
            var list = RandomMeetsProbabilityPercent(maleProbabilityPercent) ? nameListMale : nameListFemale;
            return list.Names[_randomGenerator.NextRandomInt() % list.Names.Length];
        }


        private decimal NormalizePercent(decimal percent) => Math.Max(Math.Min(percent, 100M), 0M) / 100M;
        private bool RandomMeetsProbabilityPercent(decimal percent)
        {
            percent = NormalizePercent(percent);
            var cmp = Convert.ToDecimal(_randomGenerator.NextRandomByte())/256M;
            return cmp < percent;
        }
    }
}