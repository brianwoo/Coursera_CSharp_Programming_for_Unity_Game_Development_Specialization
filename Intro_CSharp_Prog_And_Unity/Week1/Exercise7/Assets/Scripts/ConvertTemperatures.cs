using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertTemperatures : MonoBehaviour
{

    int fahrenheitToCelsius(int fahrenheit) {
        return ((fahrenheit - 32) / 9) * 5;
    }

    int celsiusToFahrenheit(int celsius) {
        return ((celsius * 9) / 5) + 32;
    }

    float fahrenheitToCelsiusFloat(float fahrenheit) {
        return ((fahrenheit - 32) / 9) * 5;
    }

    float celsiusToFahrenheitFloat(float celsius) {
        return ((celsius * 9) / 5) + 32;
    }

    double fahrenheitToCelsiusDouble(double fahrenheit) {
        return ((fahrenheit - 32) / 9) * 5;
    }

    double celsiusToFahrenheitDouble(double celsius) {
        return ((celsius * 9) / 5) + 32;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Problem 1.1
        int origTempFahrenheit = 0;
        int calculatedTempCelsius = fahrenheitToCelsius(origTempFahrenheit);
        int calculatedTempFahrenheit = celsiusToFahrenheit(calculatedTempCelsius);
        
        print("--- Problem 1.1 ---");
        print("origTempFahrenheit: " + origTempFahrenheit);
        print("calculatedTempCelsius: " + calculatedTempCelsius);
        print("calculatedTempFahrenheit: " + calculatedTempFahrenheit);

        // Problem 1.2.
        origTempFahrenheit = 32;
        calculatedTempCelsius = fahrenheitToCelsius(origTempFahrenheit);
        calculatedTempFahrenheit = celsiusToFahrenheit(calculatedTempCelsius);
        
        print("--- Problem 1.2 ---");
        print("origTempFahrenheit: " + origTempFahrenheit);
        print("calculatedTempCelsius: " + calculatedTempCelsius);
        print("calculatedTempFahrenheit: " + calculatedTempFahrenheit);

        // Problem 1.3.
        origTempFahrenheit = 212;
        calculatedTempCelsius = fahrenheitToCelsius(origTempFahrenheit);
        calculatedTempFahrenheit = celsiusToFahrenheit(calculatedTempCelsius);
        
        print("--- Problem 1.3 ---");
        print("origTempFahrenheit: " + origTempFahrenheit);
        print("calculatedTempCelsius: " + calculatedTempCelsius);
        print("calculatedTempFahrenheit: " + calculatedTempFahrenheit);


        // Problem 2.1
        float origTempFahrenheitFloat = 0;
        float calculatedTempCelsiusFloat = fahrenheitToCelsiusFloat(origTempFahrenheitFloat);
        float calculatedTempFahrenheitFloat = celsiusToFahrenheitFloat(calculatedTempCelsiusFloat);
        
        print("--- Problem 2.1 ---");
        print("origTempFahrenheit: " + origTempFahrenheitFloat);
        print("calculatedTempCelsius: " + calculatedTempCelsiusFloat);
        print("calculatedTempFahrenheit: " + calculatedTempFahrenheitFloat);

        // Problem 3.1
        double origTempFahrenheitDouble = 0;
        double calculatedTempCelsiusDouble = fahrenheitToCelsiusDouble(origTempFahrenheitFloat);
        double calculatedTempFahrenheitDouble = celsiusToFahrenheitDouble(calculatedTempCelsiusFloat);
        
        print("--- Problem 3.1 ---");
        print("origTempFahrenheit: " + origTempFahrenheitDouble);
        print("calculatedTempCelsius: " + calculatedTempCelsiusDouble);
        print("calculatedTempFahrenheit: " + calculatedTempFahrenheitDouble);
    }
}
