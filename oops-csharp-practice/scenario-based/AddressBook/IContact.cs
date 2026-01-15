using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
     interface IContact
    {
        void AddSingleContact();
        void UpdateContact();
        void DeleteContact();

        void AddMultipleContact();
        void SearchPersonByCityOrStateForMultipleAddressBook();

        //void SearchPersonByCityorState();



    }
}
