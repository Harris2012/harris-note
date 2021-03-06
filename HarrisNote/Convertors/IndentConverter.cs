﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace HarrisNote.Convertors
{
    [ValueConversion(typeof(TreeViewItem), typeof(Thickness))]
    public class IndentConverter : IValueConverter
    {
        private static readonly double colunwidth = 16;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double left = 0.0;

            UIElement element = value as TreeViewItem;
            while (element.GetType() != typeof(TreeView))
            {
                element = (UIElement)VisualTreeHelper.GetParent(element);
                if (element.GetType() == typeof(TreeViewItem))
                {
                    left += colunwidth;
                }
            }

            return new Thickness(left, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
