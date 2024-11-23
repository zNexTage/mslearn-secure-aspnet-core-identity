using QRCoder;

public class QRCodeService {
    private readonly QRCodeGenerator _generator;

    public QRCodeService(QRCodeGenerator generator)
    {
        _generator = generator;
    }

    public string GetQRCodeAsBase(string textToEncode){
        QRCodeData qRCodeData = _generator.CreateQrCode(textToEncode, QRCodeGenerator.ECCLevel.Q);

        var qrCode = new PngByteQRCode(qRCodeData);

        return Convert.ToBase64String(qrCode.GetGraphic(4)); //4 pixels ao quadrado
    }
}