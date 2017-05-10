#pragma once

#define DllEXPORT  __declspec( dllexport ) 

extern "C"
{

 DllEXPORT double Add(double a, double b);

 DllEXPORT double Subtract(double a, double b);

 DllEXPORT double Multiply(double a, double b);

 DllEXPORT double Divide(double a, double b);


}
