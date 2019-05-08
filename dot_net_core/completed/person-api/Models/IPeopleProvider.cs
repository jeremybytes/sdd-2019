using System.Collections.Generic;

namespace person_api.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}