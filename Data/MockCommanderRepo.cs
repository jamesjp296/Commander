using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var Commands =new List<Command>
            {
               new Command {Id=0, HowTo="Test",Line="Test Line",Platform="Test Platform"},
               new Command {Id=1, HowTo="Test1",Line="Test Line1",Platform="Test Platform1"},
               new Command {Id=2, HowTo="Test2",Line="Test Line2",Platform="Test Platform2"} 
            };

            return Commands;
        }
        

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo="Test",Line="Test Line",Platform="Test Platform"};
        }

        
    }

}