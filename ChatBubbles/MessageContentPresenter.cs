using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ChatBubbles
{
    public class MessageContentPresenter : ContentControl
    {
        public DataTemplate MeTemplate { get; set; }

        public DataTemplate YouTemplate { get; set; }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);

            Message message = newContent as Message;
            
            if (message.Side == MessageSide.Me)
            {
                ContentTemplate = MeTemplate;
            }
            else
            {
                ContentTemplate = YouTemplate;
            }
        }
    }
}
