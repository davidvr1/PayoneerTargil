using BL.ClientsModals;
using BL.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Factories
{
    public class Factory : IFactory
    {
        public Dictionary<int, int> _AgeById=new Dictionary<int, int> ();

        public Factory()
        {
            _AgeById.Add(12345, 19);
            _AgeById.Add(67890, 25);
            _AgeById.Add(123789, 37);
        }
        public IClient SetClientIdForProposal(int id)
        {
            
                int age = _AgeById[id];
                if (age < 20)
                {
                    return new ClientBelow20();
                }
                else if (age <= 35)
                {
                    return new ClientBetween20To35();
                }
                else
                {
                    return new ClientOver35();
                }
           
            
        }        

    }
}
