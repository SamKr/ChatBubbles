using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChatBubbles
{
    public class MessageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MeTemplate { get; set; }
        public DataTemplate YouTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var message = item as Message;
            return message.Side == MessageSide.Me ? MeTemplate : YouTemplate;
        }
    }
}
