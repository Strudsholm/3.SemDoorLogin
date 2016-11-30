using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DoorWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public void AddCard(Card composite)
        {
            DataHelper.addCard(composite);
        }

        public void AddDoor(Door composite)
        {
            DataHelper.addDoor(composite);
        }

        public void EditCard(EditCard composite)
        {
            DataHelper.EditCard(composite);
        }

        public void EditDoor(EditDoor composite)
        {
            DataHelper.EditDoor(composite);
        }

        public void DeleteCard(Card composite)
        {
            DataHelper.DeleteCard(composite);
        }

        public void DeleteDoor(Door composite)
        {
            DataHelper.DeleteDoor(composite);
        }

        public void AddDoorAccess(DoorAccess composite)
        {
            DataHelper.AddDoorAccess(composite);
        }

        public void DeleteDoorAccess(DoorAccess composite)
        {
            DataHelper.DeleteDoorAccess(composite);
        }

        public List<Card> GetCards()
        {
            return DataHelper.Cards();
        }

        public List<Door> GetDoors()
        {
            return DataHelper.Doors();
        }

        public List<DoorAccess> AccessList()
        {
            return DataHelper.AccessList();
        }

        public List<AccessLog> LogList()
        {
            return DataHelper.LogList();
        }

        public List<AccessLog> LogListOnCardId(string CardID)
        {
            return DataHelper.LogListOnCardId(CardID);
        }

        public List<AccessLog> LogListOnDoorId(string DoorID)
        {
            return DataHelper.LogListOnDoorId(DoorID);
        }
    }
}
