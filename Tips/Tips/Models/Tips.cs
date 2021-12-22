using System;
using System.Collections.Generic;
using System.Text;

namespace Tips.Models
{
    class Tips
    {
        private float m_billTotal;
        public float BillTotal 
        {
            set { m_billTotal = value; } 
        }

        private float m_bill;
        public float Bill {
            get { return m_bill;  }  
        }

        private float m_tip;
        public float Tip 
        {
            set { m_tip = value; }
        }

        private int m_split;
        public int Split
        {
            get { return m_split;  }
        }

        public float CalculateTip()
        {
            return m_billTotal * (m_tip / 100);
        }

        public float CalculateBill()
        {
            return m_billTotal / m_split ;
        }

        public float CalculateTotalPerPerson()
        {
            return CalculateTip() + CalculateBill();
        }

        public void IncreaseSplit()
        {
            m_split++;
        }

        public void DecreaseSplit()
        {
            m_split--;
        }

        public Tips() { }
    }
}
