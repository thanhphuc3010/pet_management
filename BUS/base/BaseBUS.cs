using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    // DAO: Type of DAO: ex. PetDAO, ServiceDAO
    // E: Type of DTO(Entity): ex. Pet, Service
    public abstract class BaseBUS<DAO, E> where DAO : BaseDAO<E>, new()
    {
        public DAO baseDAO = new DAO();
    }
}
