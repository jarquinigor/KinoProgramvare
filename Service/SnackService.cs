using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SnackService
    {
        private SnackRepository snackRepository = new SnackRepository();

        public string CreateSnack(Snack snack)
        {
            return snackRepository.Create(snack);
        }
        public List<Snack> GetAllSnacks()
        {
            return snackRepository.GetAll();
        }
        public Snack GetSnackById(int SnackId)
        {
            return snackRepository.GetSnack(SnackId);
        }
        public int GetSnackIdByNameSize(string Name, string Size)
        {
            return snackRepository.GetSnackId(Name, Size);
        }
        public bool ExistsSnackByNameSize(string Name, string Size)
        {
            return snackRepository.ExistsSnack(Name, Size);
        }
    }
}
