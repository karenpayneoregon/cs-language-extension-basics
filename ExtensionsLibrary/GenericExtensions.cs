﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace ExtensionsLibrary
{
    public static class GenericExtensions
    {
        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException("source");
            return ((IList) list).Contains(source);
        }
        /// <summary>
        /// Determine if T is between lower and upper
        /// </summary>
        /// <typeparam name="T">Data type</typeparam>
        /// <param name="sender">Value to determine if between lower and upper</param>
        /// <param name="minimumValue">Lower of range</param>
        /// <param name="maximumValue">Upper of range</param>
        /// <returns>True if in range, false if not in range</returns>
        /// <example>
        /// <code>
        /// var startDate = new DateTime(2018, 12, 2, 1, 12, 0);
        /// var endDate = new DateTime(2018, 12, 15, 1, 12, 0);
        /// var theDate = new DateTime(2018, 12, 13, 1, 12, 0);
        /// Assert.IsTrue(theDate.Between(startDate,endDate));
        /// </code>
        /// </example>
        public static bool Between<T>(this IComparable<T> sender, T minimumValue, T maximumValue)
        {
            return sender.CompareTo(minimumValue) >= 0 && sender.CompareTo(maximumValue) <= 0;
        }
        /// <summary>Determines if a value is between two values, exclusive.</summary>
        /// <param name="sender">The source value.</param>
        /// <param name="minimumValue">The minimum value.</param>
        /// <param name="maximumValue">The Maximum value.</param>
        /// <returns><see langword="true"/> if the value is between the two values, exclusive.</returns>
        public static bool BetweenExclusive<T>(this IComparable<T> sender, T minimumValue, T maximumValue)
        {
            return sender.CompareTo(minimumValue) > 0 && sender.CompareTo(maximumValue) < 0;
        }
        /// <summary>
        /// Adds a value uniquely to to a collection and returns
        /// a value whether the value was added or not.
        /// </summary>
        /// <typeparam name="T">The generic collection value type</typeparam>
        /// <param name="list">The collection</param>
        /// <param name="item">The value to be added.</param>
        public static void AddItem<T>(this List<T> list, T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }
    }
}
