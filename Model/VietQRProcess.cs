
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VietQRProcess {

    public VietQRProcess() {
    }

    private string stk;

    private string accountName;

    private double amount;


    public bool processPayment(Reservation reservation) {
        String qrContent = generateVietQRContent(reservation);
        try
        {
            generateQRCodeImage(qrContent, stk, accountName,amount, "qr-vietqr.png");
            return true;
        }
        catch (IOException e) {
            return false;
        }
    }

    private void generateQRCodeImage(string qrContent, string v1, string accountName, double v2, string v3)
    {
        throw new NotImplementedException();
    }

    private string generateVietQRContent(Reservation reservation)
    {
        throw new NotImplementedException();
    }
}