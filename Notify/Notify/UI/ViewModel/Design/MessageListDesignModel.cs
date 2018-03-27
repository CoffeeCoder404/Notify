using System.Collections.Generic;
using DomainModel.DTO;
using DomainModel;

namespace UI
{
    class MessageListDesignModel : MessageListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageListDesignModel Instance => new MessageListDesignModel();

        #endregion

        UiInteraction iteraction;

        #region Constructor

        public MessageListDesignModel()
        {
            try
            {
                iteraction = new UiInteraction();
                var items = iteraction.GetDetails("Message/GetMessages");
                Items = items;
            }
            catch (System.Exception e)
            {

                
            }
        }

        #endregion
    }
}
