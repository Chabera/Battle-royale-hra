using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bojovnik
    {
        private string _jmeno;

        public int HP { get; private set; }

        public Bojovnik(string jmeno)
        {

            _jmeno = jmeno;
            HP = 100;
        }
        public Bojovnik(string jmeno, int HP)
        {

            _jmeno = jmeno;
            this.HP = HP;
        }

        public string GetJmeno()
        {

            return _jmeno;
        }

        public void SetJmeno(String jmeno)
        {
            if (jmeno != "")
            {
                _jmeno = jmeno;
            }
        }

        public bool getHit(int damage)
        {

            if (damage > 0)
            {

                HP = HP - damage;
                if (HP < 0)
                {
                    HP = 0;
                }
            }
            return HP > 0;
        }

        public bool IsAlive /* jestli bojovnik zije */
        {
            get
            {
                if (HP > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string Jmeno
        {
            get { return _jmeno; }
            set { _jmeno = value; }

        }


        public void AttackFighter(Bojovnik target, bool screaming = false)
        {

            int damage;

            if (screaming)
            {
                damage = Random.Shared.Next(10, 60);
            }
            else
            {
                damage = Random.Shared.Next(0, 50);
            }
            target.getHit(damage);

        }

        public void AttackKnight(Bojovnik target, bool screaming = false)
        {
            int damage;

            if (screaming)
            {
                damage = Random.Shared.Next(10, 40);
            }
            else
            {
                damage = Random.Shared.Next(0, 40);
            }
            target.getHit(damage);
        }
    }
}
