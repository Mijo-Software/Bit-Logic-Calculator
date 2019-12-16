namespace MijoSoftware.Bytes
{
	/// <summary>
	/// Provide some methods to convert byte units
	/// </summary>
	public static class ByteUnits
	{
		/// <summary>
		/// Byte to bit conversion factor
		/// </summary>
		private const double byteToBitFactor = 8;

		/// <summary>
		/// Kilo to bit conversion factor
		/// </summary>
		private const double kilobyteToBitFactor = (double)8 * 1024;

		/// <summary>
		/// Megabyte to bit conversion factor
		/// </summary>
		private const double megabyteToBitFactor = (double)8 * 1024 * 1024;

		/// <summary>
		/// Gigabyte to bit conversion factor
		/// </summary>
		private const double gigabyteToBitFactor = (double)8 * 1024 * 1024 * 1024;

		/// <summary>
		/// Terabyte to bit conversion factor
		/// </summary>
		private const double terabyteToBitFactor = (double)8 * 1024 * 1024 * 1024 * 1024;

		/// <summary>
		/// Bit to Byte conversion factor
		/// </summary>
		private const double bitToByteFactor = 1 / byteToBitFactor;

		/// <summary>
		/// Kilobyte to byte conversion factor
		/// </summary>
		private const double kilobyteToByteFactor = 1024;

		/// <summary>
		/// Megabyte to Byte conversion factor
		/// </summary>
		private const double megabyteToByteFactor = (double)1024 * 1024;

		/// <summary>
		/// Gigabyte to byte conversion factor
		/// </summary>
		private const double gigabyteToByteFactor = (double)1024 * 1024 * 1024;

		/// <summary>
		/// Terabyte to byte conversion factor
		/// </summary>
		private const double terabyteToByteFactor = (double)1024 * 1024 * 1024 * 1024;

		/// <summary>
		/// Bit to Kilobyte conversion factor
		/// </summary>
		private const double bitToKilobyteFactor = 1 / kilobyteToBitFactor;

		/// <summary>
		/// Byte to Kilobyte conversion factor
		/// </summary>
		private const double byteToKilobyteFactor = 1 / kilobyteToByteFactor;

		/// <summary>
		/// Megabyte to kilobyte conversion factor
		/// </summary>
		private const double megabyteToKilobyteFactor = 1024;

		/// <summary>
		/// Gigabyte to kilobyte conversion factor
		/// </summary>
		private const double gigabyteToKilobyteFactor = (double)1024 * 1024;

		/// <summary>
		/// Terabyte to kilobyte conversion factor
		/// </summary>
		private const double terabyteToKilobyteFactor = (double)1024 * 1024 * 1024;

		/// <summary>
		/// Bit to megabyte conversion factor
		/// </summary>
		private const double bitToMegabyteFactor = 1 / megabyteToBitFactor;

		/// <summary>
		/// Byte to megabyte factor
		/// </summary>
		private const double byteToMegabyteFactor = 1 / megabyteToByteFactor;

		/// <summary>
		/// Kilobyte to megabyte conversion factor
		/// </summary>
		private const double kilobyteToMegabyteFactor = 1 / megabyteToKilobyteFactor;

		/// <summary>
		/// Gigabyte to megabyte conversion factor
		/// </summary>
		private const double gigabyteToMegabyteFactor = 1024;

		/// <summary>
		/// Terabyte to megabyte conversion factor
		/// </summary>
		private const double terabyteToMegabyteFactor = (double)1024 * 1024;

		/// <summary>
		/// Bit to gigabyte conversion factor
		/// </summary>
		private const double bitToGigabyteFactor = 1 / gigabyteToBitFactor;

		/// <summary>
		/// Byte to gigabyte conversion factor
		/// </summary>
		private const double byteToGigabyteFactor = 1 / gigabyteToByteFactor;

		/// <summary>
		/// Kilobyte to gigabyte conversion factor
		/// </summary>
		private const double kilobyteToGigabyteFactor = 1 / gigabyteToKilobyteFactor;

		/// <summary>
		/// Megabyte to Gigabyte conversion factor
		/// </summary>
		private const double megabyteToGigabyteFactor = 1 / gigabyteToMegabyteFactor;

		/// <summary>
		/// Terabyte to gigabyte conversion factor
		/// </summary>
		private const double terabyteToGigabyteFactor = 1024;

		/// <summary>
		/// Bit to terabyte conversion factor
		/// </summary>
		private const double bitToTerabyteFactor = 1 / terabyteToBitFactor;

		/// <summary>
		/// Byte to terabyte conversion factor
		/// </summary>
		private const double byteToTerabyteFactor = 1 / terabyteToByteFactor;

		/// <summary>
		/// Kilobyte to terabyte conversion factor
		/// </summary>
		private const double kilobyteToTerabyteFactor = 1 / terabyteToKilobyteFactor;

		/// <summary>
		/// Megabyte to terabyte conversion factor
		/// </summary>
		private const double megabyteToTerabyteFactor = 1 / terabyteToMegabyteFactor;

		/// <summary>
		/// Gigabyte to terabyte conversion factor
		/// </summary>
		private const double gigabyteToTerabyteFactor = 1 / terabyteToGigabyteFactor;

		/// <summary>
		/// Convert byte to bit
		/// </summary>
		/// <param name="value">value in bytes</param>
		/// <returns>value in bits</returns>
		public static double ByteToBit(double value) => value * byteToBitFactor;

		/// <summary>
		/// Convert kilobyte to bit
		/// </summary>
		/// <param name="value">value in kilobytes</param>
		/// <returns>value in bits</returns>
		public static double KilobyteToBit(double value) => value * kilobyteToBitFactor;

		/// <summary>
		/// Convert megabyte to bit
		/// </summary>
		/// <param name="value">value in megabytes</param>
		/// <returns>value in bits</returns>
		public static double MegabyteToBit(double value) => value * megabyteToBitFactor;

		/// <summary>
		/// Convert gigabyte to bit
		/// </summary>
		/// <param name="value">value in gigabytes</param>
		/// <returns>value in bits</returns>
		public static double GigabyteToBit(double value) => value * gigabyteToBitFactor;

		/// <summary>
		/// Convert terabyte to bit
		/// </summary>
		/// <param name="value">value in terabytes</param>
		/// <returns>value in bits</returns>
		public static double TerabyteToBit(double value) => value * terabyteToBitFactor;

		/// <summary>
		/// Convert bit to byte
		/// </summary>
		/// <param name="value">value in bits</param>
		/// <returns>value in bytes</returns>
		public static double BitToByte(double value) => value * bitToByteFactor;

		/// <summary>
		/// Convert kilobyte to byte
		/// </summary>
		/// <param name="value">value in kilobytes</param>
		/// <returns>value in bytes</returns>
		public static double KilobyteToByte(double value) => value * kilobyteToByteFactor;

		/// <summary>
		/// Convert megabyte to byte
		/// </summary>
		/// <param name="value">value in megabytes</param>
		/// <returns>value in bytes</returns>
		public static double MegabyteToByte(double value) => value * megabyteToByteFactor;

		/// <summary>
		/// Convert gigabyte to byte
		/// </summary>
		/// <param name="value">value in gigabytes</param>
		/// <returns>value in bytes</returns>
		public static double GigabyteToByte(double value) => value * gigabyteToByteFactor;

		/// <summary>
		/// Convert terabyte to byte
		/// </summary>
		/// <param name="value">value in terabytes</param>
		/// <returns>value in bytes</returns>
		public static double TerabyteToByte(double value) => value * terabyteToByteFactor;

		/// <summary>
		/// Convert bit to kilobytes
		/// </summary>
		/// <param name="value">value in bits</param>
		/// <returns>value in kilobytes</returns>
		public static double BitToKilobyte(double value) => value * bitToKilobyteFactor;

		/// <summary>
		/// Convert byte to kilobyte
		/// </summary>
		/// <param name="value">value in bytes</param>
		/// <returns>value in kilobytes</returns>
		public static double ByteToKilobyte(double value) => value * byteToKilobyteFactor;

		/// <summary>
		/// Convert megabyte to kilobyte
		/// </summary>
		/// <param name="value">value in megabytes</param>
		/// <returns>value in kilobytes</returns>
		public static double MegabyteToKilobyte(double value) => value * megabyteToKilobyteFactor;

		/// <summary>
		/// Convert gigabyte to kilobyte
		/// </summary>
		/// <param name="value">value in gigabytes</param>
		/// <returns>value in kilobytes</returns>
		public static double GigabyteToKilobyte(double value) => value * gigabyteToKilobyteFactor;

		/// <summary>
		/// Convert terabyte to kilobytes
		/// </summary>
		/// <param name="value">value in terabytes</param>
		/// <returns>value in kilobytes</returns>
		public static double TerabyteToKilobyte(double value) => value * terabyteToKilobyteFactor;

		/// <summary>
		/// Convert bit to megabyte
		/// </summary>
		/// <param name="value">value in bits</param>
		/// <returns>value in megabytes</returns>
		public static double BitToMegabyte(double value) => value * bitToMegabyteFactor;

		/// <summary>
		/// Convert byte to megabyte
		/// </summary>
		/// <param name="value">value in bytes</param>
		/// <returns>value in emgabytes</returns>
		public static double ByteToMegabyte(double value) => value * byteToMegabyteFactor;

		/// <summary>
		/// Convert kilobyte to megabyte
		/// </summary>
		/// <param name="value">value in kilobytes</param>
		/// <returns>value in megabytes</returns>
		public static double KilobyteToMegabyte(double value) => value * kilobyteToMegabyteFactor;

		/// <summary>
		/// Convert gigabyte to megabyte
		/// </summary>
		/// <param name="value">value in gigabytes</param>
		/// <returns>value in megabytes</returns>
		public static double GigabyteToMegabyte(double value) => value * gigabyteToMegabyteFactor;

		/// <summary>
		/// Convert terabyte to megabyte
		/// </summary>
		/// <param name="value">value in terabytes</param>
		/// <returns>value in megabytes</returns>
		public static double TerabyteToMegabyte(double value) => value * terabyteToMegabyteFactor;

		/// <summary>
		/// Convert bit to gigabyte
		/// </summary>
		/// <param name="value">value in bits</param>
		/// <returns>value in gigabytes</returns>
		public static double BitToGigabyte(double value) => value * bitToGigabyteFactor;

		/// <summary>
		/// Convert byte to gigabytes
		/// </summary>
		/// <param name="value">value in bytes</param>
		/// <returns>value in gigabytes</returns>
		public static double ByteToGigabyte(double value) => value * byteToGigabyteFactor;

		/// <summary>
		/// Convert kilobyte to gigabyte
		/// </summary>
		/// <param name="value">value in kilobytes</param>
		/// <returns>value in gigabytes</returns>
		public static double KilobyteToGigabyte(double value) => value * kilobyteToGigabyteFactor;

		/// <summary>
		/// Convert megabyte to gigabyte
		/// </summary>
		/// <param name="value">value in megabytes</param>
		/// <returns>value in gigabytes</returns>
		public static double MegabyteToGigabyte(double value) => value * megabyteToGigabyteFactor;

		/// <summary>
		/// Convert terabyte to gigabyte
		/// </summary>
		/// <param name="value">value in terabytes</param>
		/// <returns>value in gigabytes</returns>
		public static double TerabyteToGigabyte(double value) => value * terabyteToGigabyteFactor;

		/// <summary>
		/// Convert bit to terabyte
		/// </summary>
		/// <param name="value">value in bits</param>
		/// <returns>value in terabytes</returns>
		public static double BitToTerabyte(double value) => value * bitToTerabyteFactor;

		/// <summary>
		/// Convert byte to terabyte
		/// </summary>
		/// <param name="value">value in bytes</param>
		/// <returns>value in terabytes</returns>
		public static double ByteToTerabyte(double value) => value * byteToTerabyteFactor;

		/// <summary>
		/// Convert kilobyte to terabyte
		/// </summary>
		/// <param name="value">value in kilobytes</param>
		/// <returns>value in terabytes</returns>
		public static double KilobyteToTerabyte(double value) => value * kilobyteToTerabyteFactor;

		/// <summary>
		/// Convert megabyte to terabyte
		/// </summary>
		/// <param name="value">value in megabytes</param>
		/// <returns>value in terabytes</returns>
		public static double MegabyteToTerabyte(double value) => value * megabyteToTerabyteFactor;

		/// <summary>
		/// Convert gigabyte to terabyte
		/// </summary>
		/// <param name="value">value in gigabytes</param>
		/// <returns>value in terabytes</returns>
		public static double GigabyteToTerabyte(double value) => value * gigabyteToTerabyteFactor;
	}
}