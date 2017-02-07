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

            StackLayout stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,

                Spacing = 3.0

            };

            Content = new ScrollView
            {
                Content = new Label
                {
                    TextColor = Color.White,
                    FormattedText = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "\u2003Welcome! Let me introduce you to my family."+
                                "I must warn you, its is small but it is great! \n\n\n" + Environment.NewLine
                                + "\u2003The first and most important member of my family is my mom, "
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
                                       "She inspired me to go to college and work hard." + Environment.NewLine + ""
                            },
                            new Span
                            {
                                Text = "\u2003Next family member is the cutest one, she is one of a kind. " +
                                       "She's a loveable ball of fluff. Her name is "
                            },
                            new Span
                            {
                                Text = "Sadie." + Environment.NewLine + "",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                            },

                            new Span
                            {
                                Text = "\u2003Another member of my family is my grandma. Her name is "
                            },
                            new Span
                            {
                                Text = "Irene.",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                            },

                            new Span
                            {
                                Text = "She is my favorite grandma, and I can say that because she's the only one I've known." +
                                "She loves to sew and put puzzles together. Fun Fact about Irene, she has an identical twin sister, Iris." + Environment.NewLine,
                            },

                            new Span
                            {
                                Text = "\u2003Abbigail ",
                                FontAttributes = FontAttributes.Bold,
                                FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            },

                            new Span
                            {
                                Text = "is the 2nd cutest member of my family. She, is what some people consider, a rainbow baby." +
                                "A rainbow baby is a baby who has come after a miscarraige or two." + "She is one of the happiest of babies I have had the pleasure of meeting in my lifetime." +
                                "I am very lucky to call her my cousin."
                            },

                            new Span
                            {
                                Text = "\u2003And then there is me,"
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
                    }
                }
            };
         
       }
    }
}
