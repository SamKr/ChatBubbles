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
        // Template A: Me under you
        // Template B: You under me
        // Template C: You under you
        // Templace D: Me under me

        public DataTemplate A { get; set; }
        public DataTemplate B { get; set; }
        public DataTemplate C { get; set; }
        public DataTemplate D { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var message = item as Message;

            if (message.Side == MessageSide.Me)
            {
                return message.PrevSide == MessageSide.You ? A : D;
            }
            else
            {
                return message.PrevSide == MessageSide.You ? C : B;
            }
        }
    }
}
