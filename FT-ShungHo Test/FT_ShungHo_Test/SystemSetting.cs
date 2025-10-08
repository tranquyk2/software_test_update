using System;
using System.IO;
using System.Xml.Serialization;

namespace FT_ShungHo_Test
{
	// Token: 0x0200000D RID: 13
	public class SystemSetting
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00017528 File Offset: 0x00015728
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00017540 File Offset: 0x00015740
		public string ComPLCPort
		{
			get
			{
				return this._ComPLCPort;
			}
			set
			{
				this._ComPLCPort = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0001754C File Offset: 0x0001574C
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00017564 File Offset: 0x00015764
		public int ComPLCBaudrate
		{
			get
			{
				return this._ComPLCBaudrate;
			}
			set
			{
				this._ComPLCBaudrate = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00017570 File Offset: 0x00015770
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00017588 File Offset: 0x00015788
		public int ComPLCStopBit
		{
			get
			{
				return this._ComPLCStopBit;
			}
			set
			{
				this._ComPLCStopBit = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00017594 File Offset: 0x00015794
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000175AC File Offset: 0x000157AC
		public string ComPLCParity
		{
			get
			{
				return this._ComPLCParity;
			}
			set
			{
				this._ComPLCParity = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000175B8 File Offset: 0x000157B8
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000175D0 File Offset: 0x000157D0
		public int ComPLCDataBit
		{
			get
			{
				return this._ComPLCDataBit;
			}
			set
			{
				this._ComPLCDataBit = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000175DC File Offset: 0x000157DC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000175F4 File Offset: 0x000157F4
		public string ComLoad1Port
		{
			get
			{
				return this._ComLoad1Port;
			}
			set
			{
				this._ComLoad1Port = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00017600 File Offset: 0x00015800
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00017618 File Offset: 0x00015818
		public int ComLoad1Baudrate
		{
			get
			{
				return this._ComLoad1Baudrate;
			}
			set
			{
				this._ComLoad1Baudrate = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00017624 File Offset: 0x00015824
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0001763C File Offset: 0x0001583C
		public int ComLoad1StopBit
		{
			get
			{
				return this._ComLoad1StopBit;
			}
			set
			{
				this._ComLoad1StopBit = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00017648 File Offset: 0x00015848
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00017660 File Offset: 0x00015860
		public string ComLoad1Parity
		{
			get
			{
				return this._ComLoad1Parity;
			}
			set
			{
				this._ComLoad1Parity = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0001766C File Offset: 0x0001586C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00017684 File Offset: 0x00015884
		public int ComLoad1DataBit
		{
			get
			{
				return this._ComLoad1DataBit;
			}
			set
			{
				this._ComLoad1DataBit = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00017690 File Offset: 0x00015890
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000176A8 File Offset: 0x000158A8
		public string ComLoad2Port
		{
			get
			{
				return this._ComLoad2Port;
			}
			set
			{
				this._ComLoad2Port = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000176B4 File Offset: 0x000158B4
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000176CC File Offset: 0x000158CC
		public int ComLoad2Baudrate
		{
			get
			{
				return this._ComLoad2Baudrate;
			}
			set
			{
				this._ComLoad2Baudrate = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000176D8 File Offset: 0x000158D8
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000176F0 File Offset: 0x000158F0
		public int ComLoad2StopBit
		{
			get
			{
				return this._ComLoad2StopBit;
			}
			set
			{
				this._ComLoad2StopBit = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000176FC File Offset: 0x000158FC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00017714 File Offset: 0x00015914
		public string ComLoad2Parity
		{
			get
			{
				return this._ComLoad2Parity;
			}
			set
			{
				this._ComLoad2Parity = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00017720 File Offset: 0x00015920
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00017738 File Offset: 0x00015938
		public int ComLoad2DataBit
		{
			get
			{
				return this._ComLoad2DataBit;
			}
			set
			{
				this._ComLoad2DataBit = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00017744 File Offset: 0x00015944
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0001775C File Offset: 0x0001595C
		public string ComPowerMeter1Port
		{
			get
			{
				return this._ComPowerMeter1Port;
			}
			set
			{
				this._ComPowerMeter1Port = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00017768 File Offset: 0x00015968
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00017780 File Offset: 0x00015980
		public int ComPowerMeter1Baudrate
		{
			get
			{
				return this._ComPowerMeter1Baudrate;
			}
			set
			{
				this._ComPowerMeter1Baudrate = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0001778C File Offset: 0x0001598C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000177A4 File Offset: 0x000159A4
		public int ComPowerMeter1StopBit
		{
			get
			{
				return this._ComPowerMeter1StopBit;
			}
			set
			{
				this._ComPowerMeter1StopBit = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x000177B0 File Offset: 0x000159B0
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000177C8 File Offset: 0x000159C8
		public string ComPowerMeter1Parity
		{
			get
			{
				return this._ComPowerMeter1Parity;
			}
			set
			{
				this._ComPowerMeter1Parity = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000177D4 File Offset: 0x000159D4
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000177EC File Offset: 0x000159EC
		public int ComPowerMeter1DataBit
		{
			get
			{
				return this._ComPowerMeter1DataBit;
			}
			set
			{
				this._ComPowerMeter1DataBit = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000177F8 File Offset: 0x000159F8
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00017810 File Offset: 0x00015A10
		public string ComPowerMeter2Port
		{
			get
			{
				return this._ComPowerMeter2Port;
			}
			set
			{
				this._ComPowerMeter2Port = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0001781C File Offset: 0x00015A1C
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00017834 File Offset: 0x00015A34
		public int ComPowerMeter2Baudrate
		{
			get
			{
				return this._ComPowerMeter2Baudrate;
			}
			set
			{
				this._ComPowerMeter2Baudrate = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00017840 File Offset: 0x00015A40
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00017858 File Offset: 0x00015A58
		public int ComPowerMeter2StopBit
		{
			get
			{
				return this._ComPowerMeter2StopBit;
			}
			set
			{
				this._ComPowerMeter2StopBit = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00017864 File Offset: 0x00015A64
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0001787C File Offset: 0x00015A7C
		public string ComPowerMeter2Parity
		{
			get
			{
				return this._ComPowerMeter2Parity;
			}
			set
			{
				this._ComPowerMeter2Parity = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00017888 File Offset: 0x00015A88
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000178A0 File Offset: 0x00015AA0
		public int ComPowerMeter2DataBit
		{
			get
			{
				return this._ComPowerMeter2DataBit;
			}
			set
			{
				this._ComPowerMeter2DataBit = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000178AC File Offset: 0x00015AAC
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000178C4 File Offset: 0x00015AC4
		public string ConfigName
		{
			get
			{
				return this._configName;
			}
			set
			{
				this._configName = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000178D0 File Offset: 0x00015AD0
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000178E8 File Offset: 0x00015AE8
		public bool EnableComPLC
		{
			get
			{
				return this._enableComPLC;
			}
			set
			{
				this._enableComPLC = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000178F4 File Offset: 0x00015AF4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0001790C File Offset: 0x00015B0C
		public bool EnableComLoad1
		{
			get
			{
				return this._enableComLoad1;
			}
			set
			{
				this._enableComLoad1 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00017918 File Offset: 0x00015B18
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00017930 File Offset: 0x00015B30
		public bool EnableComLoad2
		{
			get
			{
				return this._enableComLoad2;
			}
			set
			{
				this._enableComLoad2 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0001793C File Offset: 0x00015B3C
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00017954 File Offset: 0x00015B54
		public bool EnableComPowermeter1
		{
			get
			{
				return this._enableComPowermeter1;
			}
			set
			{
				this._enableComPowermeter1 = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00017960 File Offset: 0x00015B60
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00017978 File Offset: 0x00015B78
		public bool EnableComPowermeter2
		{
			get
			{
				return this._enableComPowermeter2;
			}
			set
			{
				this._enableComPowermeter2 = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00017984 File Offset: 0x00015B84
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0001799C File Offset: 0x00015B9C
		public string ComACSource1Port
		{
			get
			{
				return this._ComACSource1Port;
			}
			set
			{
				this._ComACSource1Port = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000179A8 File Offset: 0x00015BA8
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000179C0 File Offset: 0x00015BC0
		public bool EnableACSource1
		{
			get
			{
				return this._enableACSource1;
			}
			set
			{
				this._enableACSource1 = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000179CC File Offset: 0x00015BCC
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000179E4 File Offset: 0x00015BE4
		public int ComACSource1Baudrate
		{
			get
			{
				return this._ComACSource1Baudrate;
			}
			set
			{
				this._ComACSource1Baudrate = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000179F0 File Offset: 0x00015BF0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00017A08 File Offset: 0x00015C08
		public int ComACSource1StopBit
		{
			get
			{
				return this._ComACSource1StopBit;
			}
			set
			{
				this._ComACSource1StopBit = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00017A14 File Offset: 0x00015C14
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00017A2C File Offset: 0x00015C2C
		public string ComACSource1Parity
		{
			get
			{
				return this._ComACSource1Parity;
			}
			set
			{
				this._ComACSource1Parity = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00017A38 File Offset: 0x00015C38
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00017A50 File Offset: 0x00015C50
		public int ComACSource1DataBit
		{
			get
			{
				return this._ComACSource1DataBit;
			}
			set
			{
				this._ComACSource1DataBit = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00017A5C File Offset: 0x00015C5C
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00017A74 File Offset: 0x00015C74
		public string ComACSource2Port
		{
			get
			{
				return this._ComACSource2Port;
			}
			set
			{
				this._ComACSource2Port = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00017A80 File Offset: 0x00015C80
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00017A98 File Offset: 0x00015C98
		public bool EnableACSource2
		{
			get
			{
				return this._enableACSource2;
			}
			set
			{
				this._enableACSource2 = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00017AA4 File Offset: 0x00015CA4
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00017ABC File Offset: 0x00015CBC
		public int ComACSource2Baudrate
		{
			get
			{
				return this._ComACSource2Baudrate;
			}
			set
			{
				this._ComACSource2Baudrate = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00017AC8 File Offset: 0x00015CC8
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00017AE0 File Offset: 0x00015CE0
		public int ComACSource2StopBit
		{
			get
			{
				return this._ComACSource2StopBit;
			}
			set
			{
				this._ComACSource2StopBit = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00017AEC File Offset: 0x00015CEC
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00017B04 File Offset: 0x00015D04
		public string ComACSource2Parity
		{
			get
			{
				return this._ComACSource2Parity;
			}
			set
			{
				this._ComACSource2Parity = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00017B10 File Offset: 0x00015D10
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00017B28 File Offset: 0x00015D28
		public int ComACSource2DataBit
		{
			get
			{
				return this._ComACSource2DataBit;
			}
			set
			{
				this._ComACSource2DataBit = value;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00017B34 File Offset: 0x00015D34
		public static int ReadXML<Type>(out Type pClass, string pPath)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Type));
			using (FileStream fileStream = new FileStream(pPath, FileMode.Open))
			{
				pClass = (Type)((object)xmlSerializer.Deserialize(fileStream));
			}
			return 0;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00017B90 File Offset: 0x00015D90
		public static int WriteXML<Type>(Type pClass, string pPath)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Type));
			using (FileStream fileStream = new FileStream(pPath, FileMode.Create))
			{
				xmlSerializer.Serialize(fileStream, pClass);
			}
			return 0;
		}

		// Token: 0x04000151 RID: 337
		private string _configName;

		// Token: 0x04000152 RID: 338
		private string _ComPLCPort;

		// Token: 0x04000153 RID: 339
		private bool _enableComPLC;

		// Token: 0x04000154 RID: 340
		private int _ComPLCBaudrate;

		// Token: 0x04000155 RID: 341
		private int _ComPLCStopBit;

		// Token: 0x04000156 RID: 342
		private string _ComPLCParity;

		// Token: 0x04000157 RID: 343
		private int _ComPLCDataBit;

		// Token: 0x04000158 RID: 344
		private string _ComLoad1Port;

		// Token: 0x04000159 RID: 345
		private bool _enableComLoad1;

		// Token: 0x0400015A RID: 346
		private int _ComLoad1Baudrate;

		// Token: 0x0400015B RID: 347
		private int _ComLoad1StopBit;

		// Token: 0x0400015C RID: 348
		private string _ComLoad1Parity;

		// Token: 0x0400015D RID: 349
		private int _ComLoad1DataBit;

		// Token: 0x0400015E RID: 350
		private string _ComLoad2Port;

		// Token: 0x0400015F RID: 351
		private bool _enableComLoad2;

		// Token: 0x04000160 RID: 352
		private int _ComLoad2Baudrate;

		// Token: 0x04000161 RID: 353
		private int _ComLoad2StopBit;

		// Token: 0x04000162 RID: 354
		private string _ComLoad2Parity;

		// Token: 0x04000163 RID: 355
		private int _ComLoad2DataBit;

		// Token: 0x04000164 RID: 356
		private string _ComPowerMeter1Port;

		// Token: 0x04000165 RID: 357
		private bool _enableComPowermeter1;

		// Token: 0x04000166 RID: 358
		private int _ComPowerMeter1Baudrate;

		// Token: 0x04000167 RID: 359
		private int _ComPowerMeter1StopBit;

		// Token: 0x04000168 RID: 360
		private string _ComPowerMeter1Parity;

		// Token: 0x04000169 RID: 361
		private int _ComPowerMeter1DataBit;

		// Token: 0x0400016A RID: 362
		private string _ComPowerMeter2Port;

		// Token: 0x0400016B RID: 363
		private bool _enableComPowermeter2;

		// Token: 0x0400016C RID: 364
		private int _ComPowerMeter2Baudrate;

		// Token: 0x0400016D RID: 365
		private int _ComPowerMeter2StopBit;

		// Token: 0x0400016E RID: 366
		private string _ComPowerMeter2Parity;

		// Token: 0x0400016F RID: 367
		private int _ComPowerMeter2DataBit;

		// Token: 0x04000170 RID: 368
		private string _ComACSource1Port;

		// Token: 0x04000171 RID: 369
		private bool _enableACSource1;

		// Token: 0x04000172 RID: 370
		private int _ComACSource1Baudrate;

		// Token: 0x04000173 RID: 371
		private int _ComACSource1StopBit;

		// Token: 0x04000174 RID: 372
		private string _ComACSource1Parity;

		// Token: 0x04000175 RID: 373
		private int _ComACSource1DataBit;

		// Token: 0x04000176 RID: 374
		private string _ComACSource2Port;

		// Token: 0x04000177 RID: 375
		private bool _enableACSource2;

		// Token: 0x04000178 RID: 376
		private int _ComACSource2Baudrate;

		// Token: 0x04000179 RID: 377
		private int _ComACSource2StopBit;

		// Token: 0x0400017A RID: 378
		private string _ComACSource2Parity;

		// Token: 0x0400017B RID: 379
		private int _ComACSource2DataBit;
	}
}
