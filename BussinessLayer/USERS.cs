using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class USERS
    {
        QUANLYHOCSINHEntities8 db;
        public USERS()
        {
            db = new QUANLYHOCSINHEntities8();
        }
        public tb_User getItem (string username)
        {
            return db.tb_User.FirstOrDefault(x => x.USERNAME == username);
        }

        public int Login (string username, string pass)
        {
            var us = db.tb_User.FirstOrDefault(x => x.USERNAME == username && x.MASS == pass);
            {
                if (us != null)
                {
                    return 1;
                }
                else
                    return 0;
                }
            }
        }

}

