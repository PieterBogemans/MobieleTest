﻿using System.Collections.Generic;

public class CurrencyRepository  {

    public List<Currency> Currencies { get; set; }
    public CurrencyConversionRate Rates { get; set; }

    public CurrencyRepository()
    {
        Rates = new CurrencyConversionRate();
        Currencies = new List<Currency>()
        {
            { new Currency("AED")},
            { new Currency("AFN")},
            { new Currency("ALL")},
            { new Currency("AMD")},
            { new Currency("ANG")},
            { new Currency("AOA")},
            { new Currency("ARS")},
            { new Currency("AUD")},
            { new Currency("AWG")},
            { new Currency("AZN")},
            { new Currency("BAM")},
            { new Currency("BBD")},
            { new Currency("BDT")},
            { new Currency("BGN")},
            { new Currency("BHD")},
            { new Currency("BIF")},
            { new Currency("BMD")},
            { new Currency("BND")},
            { new Currency("BOB")},
            { new Currency("BRL")},
            { new Currency("BSD")},
            { new Currency("BTC")},
            { new Currency("BTN")},
            { new Currency("BWP")},
            { new Currency("BYN")},
            { new Currency("BZD")},
            { new Currency("CAD")},
            { new Currency("CDF")},
            { new Currency("CHF")},
            { new Currency("CLF")},
            { new Currency("CLP")},
            { new Currency("CNH")},
            { new Currency("CNY")},
            { new Currency("COP")},
            { new Currency("CRC")},
            { new Currency("CUC")},
            { new Currency("CUP")},
            { new Currency("CVE")},
            { new Currency("CZK")},
            { new Currency("DJF")},
            { new Currency("DKK")},
            { new Currency("DOP")},
            { new Currency("DZD")},
            { new Currency("EGP")},
            { new Currency("ERN")},
            { new Currency("ETB")},
            { new Currency("EUR")},
            { new Currency("FJD")},
            { new Currency("FKP")},
            { new Currency("GBP")},
            { new Currency("GEL")},
            { new Currency("GGP")},
            { new Currency("GHS")},
            { new Currency("GIP")},
            { new Currency("GMD")},
            { new Currency("GNF")},
            { new Currency("GTQ")},
            { new Currency("GYD")},
            { new Currency("HKD")},
            { new Currency("HNL")},
            { new Currency("HRK")},
            { new Currency("HTG")},
            { new Currency("HUF")},
            { new Currency("IDR")},
            { new Currency("ILS")},
            { new Currency("IMP")},
            { new Currency("INR")},
            { new Currency("IQD")},
            { new Currency("IRR")},
            { new Currency("ISK")},
            { new Currency("JEP")},
            { new Currency("JMD")},
            { new Currency("JOD")},
            { new Currency("JPY")},
            { new Currency("KES")},
            { new Currency("KGS")},
            { new Currency("KHR")},
            { new Currency("KMF")},
            { new Currency("KPW")},
            { new Currency("KRW")},
            { new Currency("KWD")},
            { new Currency("KYD")},
            { new Currency("KZT")},
            { new Currency("LAK")},
            { new Currency("LBP")},
            { new Currency("LKR")},
            { new Currency("LRD")},
            { new Currency("LSL")},
            { new Currency("LYD")},
            { new Currency("MAD")},
            { new Currency("MDL")},
            { new Currency("MGA")},
            { new Currency("MKD")},
            { new Currency("MMK")},
            { new Currency("MNT")},
            { new Currency("MOP")},
            { new Currency("MRO")},
            { new Currency("MRU")},
            { new Currency("MUR")},
            { new Currency("MVR")},
            { new Currency("MWK")},
            { new Currency("MXN")},
            { new Currency("MYR")},
            { new Currency("MZN")},
            { new Currency("NAD")},
            { new Currency("NGN")},
            { new Currency("NIO")},
            { new Currency("NOK")},
            { new Currency("NPR")},
            { new Currency("NZD")},
            { new Currency("OMR")},
            { new Currency("PAB")},
            { new Currency("PEN")},
            { new Currency("PGK")},
            { new Currency("PHP")},
            { new Currency("PKR")},
            { new Currency("PLN")},
            { new Currency("PYG")},
            { new Currency("QAR")},
            { new Currency("RON")},
            { new Currency("RSD")},
            { new Currency("RUB")},
            { new Currency("RWF")},
            { new Currency("SAR")},
            { new Currency("SBD")},
            { new Currency("SCR")},
            { new Currency("SDG")},
            { new Currency("SEK")},
            { new Currency("SGD")},
            { new Currency("SHP")},
            { new Currency("SLL")},
            { new Currency("SOS")},
            { new Currency("SRD")},
            { new Currency("SSP")},
            { new Currency("STD")},
            { new Currency("STN")},
            { new Currency("SVC")},
            { new Currency("SYP")},
            { new Currency("SZL")},
            { new Currency("THB")},
            { new Currency("TJS")},
            { new Currency("TMT")},
            { new Currency("TND")},
            { new Currency("TOP")},
            { new Currency("TRY")},
            { new Currency("TTD")},
            { new Currency("TWD")},
            { new Currency("TZS")},
            { new Currency("UAH")},
            { new Currency("UGX")},
            { new Currency("USD")},
            { new Currency("UYU")},
            { new Currency("UZS")},
            { new Currency("VEF")},
            { new Currency("VND")},
            { new Currency("VUV")},
            { new Currency("WST")},
            { new Currency("XAF")},
            { new Currency("XAG")},
            { new Currency("XAU")},
            { new Currency("XCD")},
            { new Currency("XDR")},
            { new Currency("XOF")},
            { new Currency("XPD")},
            { new Currency("XPF")},
            { new Currency("XPT")},
            { new Currency("YER")},
            { new Currency("ZAR")},
            { new Currency("ZMW")},
            { new Currency("ZWL")},
        };
    }


    public Currency GetCurrencyWithName(string currencyCode)
    {
        foreach(Currency currency in Currencies)
        {
            if (currency.CurrencyCode.Equals(currencyCode))
            {
                return currency;
            }
        }
        return null;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
