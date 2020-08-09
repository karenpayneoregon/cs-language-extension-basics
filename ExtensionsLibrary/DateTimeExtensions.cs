﻿using System;
using System.Globalization;

namespace ExtensionsLibrary
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert TimeSpan into DateTime
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        /// <remarks>
        /// Intended to be used when the date part does not matter
        /// </remarks>
        public static DateTime ToDateTime(this TimeSpan sender)
        {
            return DateTime.ParseExact(sender.Formatted("hh:mm"), 
                "H:mm", null, DateTimeStyles.None);
        }
        /// <summary>
        /// Format a TimeSpan with AM PM
        /// </summary>
        /// <param name="sender">TimeSpan to format</param>
        /// <param name="format">Optional format</param>
        /// <returns></returns>
        public static string Formatted(this TimeSpan sender, string format = "hh:mm tt")
        {
            return DateTime.Today.Add(sender).ToString(format);
        }
    }
}
