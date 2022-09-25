using SuperChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Hansen",
                UsernameColor = "#409aff",
                ImageSource = "https://cdnb.artstation.com/p/users/avatars/003/358/037/large/50ba09a57b1854dccc63922e98bf4ac6.jpg?1629554980",
                Message = "Teste",
                Time = DateTime.Now,
                isNativeOrigin = false,
                FirtMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Hansen",
                    UsernameColor = "#409aff",
                    ImageSource = "https://cdnb.artstation.com/p/users/avatars/003/358/037/large/50ba09a57b1854dccc63922e98bf4ac6.jpg?1629554980",
                    Message = "Teste",
                    Time = DateTime.Now,
                    isNativeOrigin = false,
                    FirtMessage = false
                });
            }


            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Bárbara",
                    UsernameColor = "#409aff",
                    ImageSource = "https://cdnb.artstation.com/p/users/avatars/003/358/037/large/50ba09a57b1854dccc63922e98bf4ac6.jpg?1629554980",
                    Message = "Teste",
                    Time = DateTime.Now,
                    isNativeOrigin = false,
                    FirtMessage = true
                });
            }
            Messages.Add(new MessageModel
            {
                Username = "Bárbara",
                UsernameColor = "#409aff",
                ImageSource = "https://cdnb.artstation.com/p/users/avatars/003/358/037/large/50ba09a57b1854dccc63922e98bf4ac6.jpg?1629554980",
                Message = "Último",
                Time = DateTime.Now,
                isNativeOrigin = false,
                FirtMessage = true
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Gabriel {i}",
                    ImageSource = "https://cdnb.artstation.com/p/users/avatars/003/358/037/large/50ba09a57b1854dccc63922e98bf4ac6.jpg?1629554980",
                    Messages = Messages

                });
            }

        }
       
    }
}
