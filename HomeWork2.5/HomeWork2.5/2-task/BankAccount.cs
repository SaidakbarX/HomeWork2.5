using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5._2_task;

public class BankAccount
{
	private int _accountNumber;

	public int AccountNumber
	{
		get { return _accountNumber; }
		set { _accountNumber = value; }
	}
	private double _balance = 0;

	public double Balance 
	{
		get { return _balance = 0; }
	
	}

	public void Deposit(double amount)
	{
		_balance += amount;
	}

}
