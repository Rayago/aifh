﻿using System;
using System.Text;

namespace AIFH_Vol2.Examples.Capstone.Model.Milestone1
{
    /// <summary>
    ///     Used to calculate survival by male and female.
    /// </summary>
    public class CalcSurvival
    {
        /// <summary>
        ///     The count of females.
        /// </summary>
        private int _countFemale;

        /// <summary>
        ///     The count of males.
        /// </summary>
        private int _countMale;

        /// <summary>
        ///     The count of female survivors.
        /// </summary>
        private int _femaleSurvive;

        /// <summary>
        ///     The count of male survivors.
        /// </summary>
        private int _maleSurvive;

        /// <summary>
        ///     The number of male survivors.
        /// </summary>
        public int MaleSurvive
        {
            get { return _maleSurvive; }
        }

        /// <summary>
        ///     The number of female survivors.
        /// </summary>
        public int FemaleSurvive
        {
            get { return _femaleSurvive; }
        }

        /// <summary>
        ///     The total count of passengers.
        /// </summary>
        public int Count
        {
            get { return _countFemale + _countMale; }
        }

        /// <summary>
        ///     The number of male passengers.
        /// </summary>
        public int CountMale
        {
            get { return _countMale; }
        }

        /// <summary>
        ///     The number of female passengers.
        /// </summary>
        public int CountFemale
        {
            get { return _countFemale; }
        }

        /// <summary>
        ///     Update for a passenger.
        /// </summary>
        /// <param name="male">True, if passenger was male.</param>
        /// <param name="survived">True, if passenger survived.</param>
        public void Update(bool male, bool survived)
        {
            if (male)
            {
                _countMale++;
            }
            else
            {
                _countFemale++;
            }
            if (survived)
            {
                if (male)
                {
                    _maleSurvive++;
                }
                else
                {
                    _femaleSurvive++;
                }
            }
        }

        /// <inheritdoc />
        public override String ToString()
        {
            var result = new StringBuilder();
            result.Append("(");

            result.Append("Count: ");
            result.Append(Count);

            if (Count > 0)
            {
                double pct = (double) (_femaleSurvive + _maleSurvive)/Count;
                result.Append(", survived: ");
                result.Append(pct);
            }

            if (CountMale > 0)
            {
                double pct = (double) (_maleSurvive)/(_countMale);
                result.Append(", male.survived: ");
                result.Append(pct);
            }

            if (CountFemale > 0)
            {
                double pct = (double) (_femaleSurvive)/(_countFemale);
                result.Append(", female.survived: ");
                result.Append(pct);
            }

            result.Append(")");
            return result.ToString();
        }
    }
}