#include "SimpleFunctions.h"
#include <stdexcept>


double Add(double a, double b)
{
	return a + b;
}

double Subtract(double a, double b)
{
	return a - b;
}

double Multiply(double a, double b)
{
	return a * b;
}

double Divide(double a, double b)
{
	if (b == 0)
	{
		throw new std::invalid_argument("b cannot be zero!");
	}

	return a / b;
}
