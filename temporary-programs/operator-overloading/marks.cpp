/**
 * Program with examples of some basic operators overloaded
 *
 * Author: Dhaval Anjaria
 * Date: 2015-12-03
 */

#include <iostream>

using namespace std;

class Marks
{
	int subject1, subject2, subject3;

public:
	// Constructors
	Marks()
	{
		subject1 = 0;
		subject2 = 0;
		subject3 = 0;
	}

	Marks(int s1, int s2, int s3)
	{
		subject1 = s1;
		subject2 = s2;
		subject3 = s3;
	}

	// Methods
	void printMarks()
	{
		cout << "Subject 1: " << subject1 << endl;
		cout << "Subject 2: " << subject2 << endl;
		cout << "Subject 3: " << subject3 << endl;
	}

	// Operator Overload methods
	// Since this is a member function, the LHS will be the return
	// type and RHS will be a function parameter
	// Note: We are using const reference because we can pass anything
	// to it, i.e. pointers to an object, regular object, reference,
	// anything.
	

	// Arithmetic operators
	Marks operator+(const Marks &m2)
	{
		int s1 = subject1 + m2.subject1;
		int s2 = subject2 + m2.subject2;
		int s3 = subject3 + m2.subject3;

		return Marks(s1,s2,s3);
	}

	Marks operator-(const Marks &m2)
	{
		int s1 = subject1 - m2.subject1;
		int s2 = subject2 - m2.subject2;
		int s3 = subject3 - m2.subject3;

		return Marks(s1,s2,s3);
	}

	Marks operator*(const Marks &m2)
	{
		int s1 = subject1 * m2.subject1;
		int s2 = subject2 * m2.subject2;
		int s3 = subject3 * m2.subject3;

		return Marks(s1,s2,s3);
	}

	
	// Boolean operator example
	// This one takes a total. All the other operators would be
	// overloaded the same way
	bool operator<(const Marks &m2)
	{
		int lhs_total= subject1 + subject2 + subject3;
		int rhs_total= m2.subject1 + m2.subject2 + m2.subject3;

		if(lhs_total < rhs_total)
			return true;
		else
			return false;
	}


	bool operator>(const Marks &m2)
	{
		int lhs_total= subject1 + subject2 + subject3;
		int rhs_total= m2.subject1 + m2.subject2 + m2.subject3;

		if(lhs_total > rhs_total)
			return true;
		else
			return false;
	}

	
	// Unary operator example
	// This only works as a prefix (i.e ++obj)
	void operator++()
	{
		subject1++;
		subject2++;
		subject3++;
	}

	// This one works with postfix (i.e. obj++)
	void operator++(int)
	{
		subject1++;
		subject2++;
		subject3++;
	}

	// Assignment Operator and its variants
	Marks operator=(const Marks &m2)
	{
		this->subject1 = m2.subject1;
		this->subject2 = m2.subject2;
		this->subject3 = m2.subject3;

		return *this;
	}

	Marks operator*=(const Marks &m2)
	{
		subject1 *= m2.subject1;
		subject2 *= m2.subject2;
		subject3 *= m2.subject3;

		return *this;
	}

	// Finally, the << and the >> operators
	// These cannot be defined as member functions since they already take 
	// the implicit `this` parameter
	friend ostream &operator<<(ostream &os, const Marks &m2)
	{
		os << m2.subject1 << " " << m2.subject2 << " " << m2.subject3;
		return os;
	}

	// Note: We don't use a const reference here.
	// Since we're changing the object
	friend istream &operator>>(istream &is, Marks &m2)
	{
		is >> m2.subject1 >> m2.subject2 >> m2.subject3;
		return is;
	}
};



int main()
{
	Marks m1(10, 20, 30);
	Marks m2(10, 20, 30);

	Marks m3 = m1 + m2;
	cout << "For M3... " << endl;
	m3.printMarks();

	m1 *= m2;
	cout << "M1: " << m1 << endl;
	
	if(m1 > m2)
	{
		cout << "M1 is greater than m2" << endl;
	}

	return 0;
}
