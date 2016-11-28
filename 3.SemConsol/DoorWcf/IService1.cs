using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DoorWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddCard(Card composite);

        [OperationContract]
        void AddDoor(Door composite);

        [OperationContract]
        void EditCard(EditCard composite);

        [OperationContract]
        void EditDoor(EditDoor composite);

        [OperationContract]
        void DeleteCard(Card composite);

        [OperationContract]
        void DeleteDoor(Door composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Card
    {
        private string _cardId;

        [DataMember]
        public string CardId
        {
            get { return _cardId; }
            set { _cardId = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Card))
            {
                return false;
            }
            else
            {
                Card CardObj = (Card) obj;
                if (CardId.Equals(CardObj.CardId) && _cardId.Equals(CardObj.CardId))
                {
                    return true;
                }
                return false;
            }
        }



    }

    [DataContract]
    public class Door
    {
        private int _doorId;

        [DataMember]
        public int DoorId
        {
            get { return _doorId; }
            set { _doorId = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Door))
            {
                return false;
            }
            else
            {
                Door CardObj = (Door) obj;
                if (DoorId.Equals(CardObj.DoorId) && _doorId.Equals(CardObj.DoorId))
                {
                    return true;
                }
                return false;
            }
        }
    }

    [DataContract]
    public class EditCard
    {
        private string _oldCardnr;
        private string _newCardnr;

        [DataMember]
        public string OldCardnr
        {
            get { return _oldCardnr; }
            set { _oldCardnr = value; }
        }

        [DataMember]
        public string NewCardnr
        {
            get { return _newCardnr; }
            set { _newCardnr = value; }
        }
    }

    [DataContract]
    public class EditDoor
    {
        private int _oldDoornr;
        private int _newDoornr;

        [DataMember]
        public int OldDoornr
        {
            get { return _oldDoornr; }
            set { _oldDoornr = value; }
        }

        [DataMember]
        public int NewDoornr
        {
            get { return _newDoornr; }
            set { _newDoornr = value; }
        }
    }
}
