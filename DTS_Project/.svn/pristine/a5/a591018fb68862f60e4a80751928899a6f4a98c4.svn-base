using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: Class representing a number
    /// dialed by a given tenant. 
    /// </summary>
    [Serializable]
    public class Number
    {
        /// <summary>
        /// The area code of the number.
        /// </summary>
        private string _areaCode;
        /// <summary>
        /// The number's exchange.
        /// </summary>
        private string _exchange;
        /// <summary>
        /// The subscriber section of the number.
        /// </summary>
        private string _subscriber;
        /// <summary>
        /// String builder used to generate a string 
        /// representation of this number.
        /// </summary>
        private StringBuilder sb;

        /// <summary>
        /// Non-default constructor.
        /// </summary>
        /// <param name="number">An array of strings used to 
        /// construct a number.</param>
        public Number(string [] number)
        {
            _areaCode = number[0];
            _exchange = number[1];
            _subscriber = number[2];
            sb = new StringBuilder();
        }

        /// <summary>
        /// ToString override.
        /// </summary>
        /// <returns>A string representation of a number.</returns>
        public override string ToString()
        {
            //Reset the builder
            sb.Clear();

            sb.Append(_areaCode); sb.Append("-");
            sb.Append(_exchange); sb.Append("-");
            sb.Append(_subscriber);

            return sb.ToString();
        }

        /// <summary>
        /// Returns the area code.
        /// </summary>
        public string AreaCode
        {
            get
            {
                return _areaCode;
            }
        }

        /// <summary>
        /// Returns the exchange.
        /// </summary>
        public string Exchange
        {
            get
            {
                return _exchange;
            }
        }

        /// <summary>
        /// Returns the subscriber section.
        /// </summary>
        public string Subscriber
        {
            get
            {
                return _subscriber;
            }
        }
    }
}
