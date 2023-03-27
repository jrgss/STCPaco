USE [master]
GO
/****** Object:  Database [PROYECTO]    Script Date: 12/03/2023 22:26:41 ******/
CREATE DATABASE [PROYECTO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PROYECTO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PROYECTO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PROYECTO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PROYECTO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PROYECTO] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROYECTO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROYECTO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROYECTO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROYECTO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROYECTO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROYECTO] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROYECTO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PROYECTO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROYECTO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROYECTO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROYECTO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROYECTO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROYECTO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROYECTO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROYECTO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROYECTO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PROYECTO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROYECTO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROYECTO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROYECTO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROYECTO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROYECTO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROYECTO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROYECTO] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PROYECTO] SET  MULTI_USER 
GO
ALTER DATABASE [PROYECTO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROYECTO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROYECTO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROYECTO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROYECTO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PROYECTO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PROYECTO] SET QUERY_STORE = OFF
GO
USE [PROYECTO]
GO
/****** Object:  Table [dbo].[COMPETICION]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPETICION](
	[IDCOMPETICION] [int] NOT NULL,
	[NOMBRE] [nvarchar](100) NULL,
	[TIPOCOMPE] [nvarchar](50) NULL,
	[LOGO] [nvarchar](300) NULL,
	[PAIS] [nvarchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCOMPETICION] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPETICION_DURANTE_TEMPORADA]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPETICION_DURANTE_TEMPORADA](
	[IDCOMPETICION] [int] NOT NULL,
	[IDTEMPORADA] [int] NOT NULL,
	[STARTDATE] [datetime] NULL,
	[ENDDATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCOMPETICION] ASC,
	[IDTEMPORADA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EQUIPO]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EQUIPO](
	[IDEQUIPO] [int] NOT NULL,
	[NOMBRE] [nvarchar](100) NULL,
	[ABREVIATURA] [nvarchar](5) NULL,
	[LOGO] [nvarchar](300) NULL,
	[IDVENUE] [int] NULL,
	[PAIS] [nvarchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEQUIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EQUIPO_PARTICIPA_COMPETICION]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EQUIPO_PARTICIPA_COMPETICION](
	[IDCOMPETICION] [int] NOT NULL,
	[IDTEMPORADA] [int] NOT NULL,
	[IDEQUIPO] [int] NOT NULL,
	[PARTIDOSJUGADOS] [int] NULL,
	[PARTIDOSJUGADOSLOCAL] [int] NULL,
	[PARTIDOSJUGADOSVISITANTE] [int] NULL,
	[VICTORIAS] [int] NOT NULL,
	[VICTORIASLOCAL] [int] NOT NULL,
	[VICTORIASVISITANTE] [int] NOT NULL,
	[EMPATES] [int] NOT NULL,
	[EMPATESLOCAL] [int] NOT NULL,
	[EMPATESVISITANTE] [int] NOT NULL,
	[DERROTAS] [int] NOT NULL,
	[DERROTASLOCAL] [int] NOT NULL,
	[DERROTASVISITANTE] [int] NOT NULL,
	[GOLESMARCADOS] [int] NOT NULL,
	[GOLESMARCADOSLOCAL] [int] NOT NULL,
	[GOLESMARCADOSVISITANTE] [int] NOT NULL,
	[GOLESENCAJADOS] [int] NOT NULL,
	[GOLESENCAJADOSLOCAL] [int] NOT NULL,
	[GOLESENCAJADOSVISITANTE] [int] NOT NULL,
	[TARJETASAMARILLAS] [int] NOT NULL,
	[TARJETASAMARILLASLOCAL] [int] NOT NULL,
	[TARJETASAMARILLASVISITANTE] [int] NOT NULL,
	[TARJETASROJAS] [int] NOT NULL,
	[TARJETASROJASLOCAL] [int] NOT NULL,
	[TARJETASROJASVISITANTE] [int] NOT NULL,
	[PUNTOS] [int] NOT NULL,
	[GOLESFAVOR0_15] [int] NOT NULL,
	[GOLESFAVOR16_30] [int] NOT NULL,
	[GOLESFAVOR31_45] [int] NOT NULL,
	[GOLESFAVOR46_60] [int] NOT NULL,
	[GOLESFAVOR61_75] [int] NOT NULL,
	[GOLESFAVOR76_90] [int] NOT NULL,
	[GOLESFAVOR91_105] [int] NOT NULL,
	[GOLESFAVOR106_120] [int] NOT NULL,
	[GOLESCONTRA0_15] [int] NOT NULL,
	[GOLESCONTRA16_30] [int] NOT NULL,
	[GOLESCONTRA31_45] [int] NOT NULL,
	[GOLESCONTRA46_60] [int] NOT NULL,
	[GOLESCONTRA61_75] [int] NOT NULL,
	[GOLESCONTRA76_90] [int] NOT NULL,
	[GOLESCONTRA91_105] [int] NOT NULL,
	[GOLESCONTRA106_120] [int] NOT NULL,
	[NOMBRE] [nvarchar](100) NULL,
	[TARJETASAMARILLAS0_15] [int] NOT NULL,
	[TARJETASAMARILLAS16_30] [int] NOT NULL,
	[TARJETASAMARILLAS31_45] [int] NOT NULL,
	[TARJETASAMARILLAS46_60] [int] NOT NULL,
	[TARJETASAMARILLAS61_75] [int] NOT NULL,
	[TARJETASAMARILLAS76_90] [int] NOT NULL,
	[TARJETASAMARILLAS91_105] [int] NOT NULL,
	[TARJETASAMARILLAS106_120] [int] NOT NULL,
	[TARJETASROJAS0_15] [int] NOT NULL,
	[TARJETASROJAS16_30] [int] NOT NULL,
	[TARJETASROJAS31_45] [int] NOT NULL,
	[TARJETASROJAS46_60] [int] NOT NULL,
	[TARJETASROJAS61_75] [int] NOT NULL,
	[TARJETASROJAS76_90] [int] NOT NULL,
	[TARJETASROJAS91_105] [int] NOT NULL,
	[TARJETASROJAS106_120] [int] NOT NULL,
	[POSICION] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCOMPETICION] ASC,
	[IDTEMPORADA] ASC,
	[IDEQUIPO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PARTIDO]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PARTIDO](
	[IDPARTIDO] [int] NOT NULL,
	[IDCOMPETICION] [int] NULL,
	[IDTEMPORADA] [int] NULL,
	[ARBITRO] [nvarchar](70) NULL,
	[TIMEZONO] [nvarchar](20) NULL,
	[STARTDATE] [datetime] NULL,
	[IDVENUE] [int] NULL,
	[IDLOCAL] [int] NULL,
	[IDVISITANTE] [int] NULL,
	[GOLESLOCALHF] [int] NULL,
	[GOLESVISITANTEHF] [int] NULL,
	[GOLESLOCALFT] [int] NULL,
	[GOLESVISITANTE] [int] NULL,
	[GOLESLOCALET] [int] NULL,
	[GOLESVISITANTEET] [int] NULL,
	[GOLESLOCALPENALTY] [int] NULL,
	[GOLESVISITANTEPENALTY] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPARTIDO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEMPORADA]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEMPORADA](
	[IDTEMPORADA] [int] NOT NULL,
	[STARTDATE] [datetime] NULL,
	[ENDDATE] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTEMPORADA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENUE]    Script Date: 12/03/2023 22:26:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENUE](
	[IDVENUE] [int] NOT NULL,
	[NOMBRE] [nvarchar](100) NULL,
	[CIUDAD] [nvarchar](100) NULL,
	[CAPACIDAD] [int] NULL,
	[PAIS] [nvarchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDVENUE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EQUIPO_PARTICIPA_COMPETICION] ADD  CONSTRAINT [constraint_default_cero]  DEFAULT ((0)) FOR [POSICION]
GO
ALTER TABLE [dbo].[COMPETICION_DURANTE_TEMPORADA]  WITH CHECK ADD FOREIGN KEY([IDCOMPETICION])
REFERENCES [dbo].[COMPETICION] ([IDCOMPETICION])
GO
ALTER TABLE [dbo].[COMPETICION_DURANTE_TEMPORADA]  WITH CHECK ADD FOREIGN KEY([IDTEMPORADA])
REFERENCES [dbo].[TEMPORADA] ([IDTEMPORADA])
GO
ALTER TABLE [dbo].[EQUIPO]  WITH CHECK ADD FOREIGN KEY([IDVENUE])
REFERENCES [dbo].[VENUE] ([IDVENUE])
GO
ALTER TABLE [dbo].[EQUIPO_PARTICIPA_COMPETICION]  WITH CHECK ADD FOREIGN KEY([IDCOMPETICION])
REFERENCES [dbo].[COMPETICION] ([IDCOMPETICION])
GO
ALTER TABLE [dbo].[EQUIPO_PARTICIPA_COMPETICION]  WITH CHECK ADD FOREIGN KEY([IDEQUIPO])
REFERENCES [dbo].[EQUIPO] ([IDEQUIPO])
GO
ALTER TABLE [dbo].[EQUIPO_PARTICIPA_COMPETICION]  WITH CHECK ADD FOREIGN KEY([IDTEMPORADA])
REFERENCES [dbo].[TEMPORADA] ([IDTEMPORADA])
GO
ALTER TABLE [dbo].[PARTIDO]  WITH CHECK ADD FOREIGN KEY([IDCOMPETICION])
REFERENCES [dbo].[COMPETICION] ([IDCOMPETICION])
GO
ALTER TABLE [dbo].[PARTIDO]  WITH CHECK ADD FOREIGN KEY([IDLOCAL])
REFERENCES [dbo].[EQUIPO] ([IDEQUIPO])
GO
ALTER TABLE [dbo].[PARTIDO]  WITH CHECK ADD FOREIGN KEY([IDTEMPORADA])
REFERENCES [dbo].[TEMPORADA] ([IDTEMPORADA])
GO
ALTER TABLE [dbo].[PARTIDO]  WITH CHECK ADD FOREIGN KEY([IDVENUE])
REFERENCES [dbo].[VENUE] ([IDVENUE])
GO
ALTER TABLE [dbo].[PARTIDO]  WITH CHECK ADD FOREIGN KEY([IDVISITANTE])
REFERENCES [dbo].[EQUIPO] ([IDEQUIPO])
GO
USE [master]
GO
ALTER DATABASE [PROYECTO] SET  READ_WRITE 
GO
