USE [biletSatis]
GO
/****** Object:  Table [dbo].[Koltuk]    Script Date: 20.05.2020 04:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Koltuk](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SalonID] [int] NULL,
	[koltukAdi] [nvarchar](20) NULL,
	[BiletFiyati] [decimal](18, 2) NULL,
	[doluluk] [bit] NULL,
 CONSTRAINT [PK_Koltuk] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[odemeSekli]    Script Date: 20.05.2020 04:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odemeSekli](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[odemeTuru] [nvarchar](50) NULL,
 CONSTRAINT [PK_odemeSekli] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salon]    Script Date: 20.05.2020 04:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SalonAdı] [nvarchar](50) NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Satis]    Script Date: 20.05.2020 04:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tutar] [decimal](18, 2) NULL,
	[tarih] [datetime] NULL CONSTRAINT [DF_Satis_tarih]  DEFAULT (getdate()),
	[odemeSekliID] [int] NULL,
	[musteriAd] [nvarchar](50) NULL,
	[musteriSoyad] [nvarchar](50) NULL,
	[salonID] [int] NULL,
	[koltukID] [int] NULL,
 CONSTRAINT [PK_Satis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Koltuk] ON 

INSERT [dbo].[Koltuk] ([id], [SalonID], [koltukAdi], [BiletFiyati], [doluluk]) VALUES (1, 1, N'A1', CAST(12.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Koltuk] ([id], [SalonID], [koltukAdi], [BiletFiyati], [doluluk]) VALUES (2, 1, N'A2', CAST(12.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Koltuk] ([id], [SalonID], [koltukAdi], [BiletFiyati], [doluluk]) VALUES (3, 2, N'A1', CAST(12.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Koltuk] ([id], [SalonID], [koltukAdi], [BiletFiyati], [doluluk]) VALUES (4, 2, N'A2', CAST(12.00 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[Koltuk] OFF
SET IDENTITY_INSERT [dbo].[odemeSekli] ON 

INSERT [dbo].[odemeSekli] ([id], [odemeTuru]) VALUES (1, N'Nakit')
INSERT [dbo].[odemeSekli] ([id], [odemeTuru]) VALUES (2, N'Kredi Kartı')
SET IDENTITY_INSERT [dbo].[odemeSekli] OFF
SET IDENTITY_INSERT [dbo].[Salon] ON 

INSERT [dbo].[Salon] ([id], [SalonAdı]) VALUES (1, N'Salon 1')
INSERT [dbo].[Salon] ([id], [SalonAdı]) VALUES (2, N'Salon 2')
SET IDENTITY_INSERT [dbo].[Salon] OFF
SET IDENTITY_INSERT [dbo].[Satis] ON 

INSERT [dbo].[Satis] ([id], [tutar], [tarih], [odemeSekliID], [musteriAd], [musteriSoyad], [salonID], [koltukID]) VALUES (1, CAST(12.00 AS Decimal(18, 2)), CAST(N'2020-05-20 02:51:33.193' AS DateTime), 1, N'Test Ad', N'Test Soyad', 1, 1)
INSERT [dbo].[Satis] ([id], [tutar], [tarih], [odemeSekliID], [musteriAd], [musteriSoyad], [salonID], [koltukID]) VALUES (2, CAST(12.00 AS Decimal(18, 2)), CAST(N'2020-05-20 03:07:17.187' AS DateTime), 2, N'test', N'test', 2, 3)
SET IDENTITY_INSERT [dbo].[Satis] OFF
ALTER TABLE [dbo].[Koltuk]  WITH CHECK ADD  CONSTRAINT [FK_Koltuk_Salon] FOREIGN KEY([SalonID])
REFERENCES [dbo].[Salon] ([id])
GO
ALTER TABLE [dbo].[Koltuk] CHECK CONSTRAINT [FK_Koltuk_Salon]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_Satis_Koltuk] FOREIGN KEY([koltukID])
REFERENCES [dbo].[Koltuk] ([id])
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_Satis_Koltuk]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_Satis_odemeSekli] FOREIGN KEY([odemeSekliID])
REFERENCES [dbo].[odemeSekli] ([id])
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_Satis_odemeSekli]
GO
ALTER TABLE [dbo].[Satis]  WITH CHECK ADD  CONSTRAINT [FK_Satis_Salon] FOREIGN KEY([salonID])
REFERENCES [dbo].[Salon] ([id])
GO
ALTER TABLE [dbo].[Satis] CHECK CONSTRAINT [FK_Satis_Salon]
GO
