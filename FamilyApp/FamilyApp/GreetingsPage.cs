using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FamilyApp
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            BackgroundColor = Color.Teal;
            

            Content = new Label
            {

                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "\u2003Welcome! Let me introduce you to my family."+ 
                            "I must warn you, its is small but it is great! \n\n\n" + Environment.NewLine
                            + "The first and most important member of my family is my mom, "
                        },
                        new Span
                        {
                            Text = "Julie",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = " My mom is one of the strongest, most determined, woman I know." +
                                   "She raised me as a single parent, while continuing her education and working full time. " +
                                   "She inspired me to go to college and work hard.\n\n\n" + Environment.NewLine + ""
                        },
                        new Span
                        {
                            Text = "Next family member is the cutest one, she is one of a kind. " +
                                   "She's a loveable ball of fluff. Her name is "
                        },
                        new Span
                        {
                            Text = "Sadie. \n\n\n" + Environment.NewLine + "",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = "And then there was me,"
                        },
                        new Span
                        {
                            Text = " Breanna.",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = " I'm 24 years old and have 3 half siblings that I met, online, last year." +
                            "I love my small family and can't wait to see what the future holds."
                        }
                    }
                },

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.White,

            };
        }
    }
}
