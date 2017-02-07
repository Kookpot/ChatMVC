using Microsoft.AspNet.SignalR;

namespace ChatMVC.Hubs
{
    /// <summary>
    /// our chat hub
    /// </summary>
    public class ChatHub : Hub
    {
        #region Public Methods

        /// <summary>
        /// someone send a message
        /// </summary>
        /// <param name="userName">name of the user who sends a message</param>
        /// <param name="message">content of the message</param>
        public void Send(string userName, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(userName, message);
        }

        #endregion
    }
}