USE [master]
GO
/****** Object:  Database [SMPORTFOLIO]    Script Date: 04/27/2015 16:33:18 ******/
CREATE DATABASE [SMPORTFOLIO] ON  PRIMARY 
( NAME = N'SMPortfolio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SMPORTFOLIO.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SMPortfolio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SMPORTFOLIO_1.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SMPORTFOLIO] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMPORTFOLIO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMPORTFOLIO] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET ARITHABORT OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SMPORTFOLIO] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SMPORTFOLIO] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SMPORTFOLIO] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET  DISABLE_BROKER
GO
ALTER DATABASE [SMPORTFOLIO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SMPORTFOLIO] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SMPORTFOLIO] SET  READ_WRITE
GO
ALTER DATABASE [SMPORTFOLIO] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SMPORTFOLIO] SET  MULTI_USER
GO
ALTER DATABASE [SMPORTFOLIO] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SMPORTFOLIO] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'SMPORTFOLIO', N'ON'
GO
USE [SMPORTFOLIO]
GO
/****** Object:  Table [dbo].[Competence]    Script Date: 04/27/2015 16:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [text] NULL,
	[CompetenceType] [int] NULL,
	[LogoUrl] [nvarchar](100) NULL,
 CONSTRAINT [PK_Competence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Competence] ON
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (1, N'Developper en ASP.NET (C#)', N'<p>Le C# est un langage de programmation orienté objet créé par la société Microsoft.  Syntaxiquement très proche du Java mais aussi du C et du C++, il a été créé pour que la plateforme .NET aie un langage permettant d`utiliser toutes ses capacités.  Il est utilisé principalement avec l`illustre Visual Studio, l`IDE de Microsoft. </p>  Le C# est certainement le langage que j`ai eu le plus l`occasion de manipuler, que ce soit dans mon cursus étudiant ou dans le monde professionnel.     En effet, j`ai pu découvrir le C# ainsi que la programmation orientée objet grâce à la première version du projet TiDoi. J`ai ainsi pu mettre en pratique les concepts de bases que sont les notions d`objet, classe, instance, héritage, polymorphisme...  Grâce au deuxième projet TiDoi j`ai pu approfondir mes connaissances et aller un peu plus loin, avec notamment la découverte de l`architecture MVC à travers le framework Orchard, un CMS ciblant majoritairement les développeurs.  Le projet MKS (toujours à IN`TECH INFO) m`a permis de découvrir le C# sous un angle différent. Notre mission était de rajouter un module à un site web existant. Nous avons donc du étudier du code écrit par d`autres développeurs, le comprendre, le critiquer. Puis ensuite créer notre module avec les mêmes conventions de codages.', 1, N'csharp-logo.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (2, N'Développer en PHP', N'PHP est un langage de programmation orienté objet principalement utilisé pour produire des pages Web dynamiques. Il est multiplateforme, et peut tourner sur n''importe quelle machine ayant un serveur HTTP. Très flexible et souple, le PHP est simple d''utilisation et d''apprentissage. Néanmoins, il n''a pas que des avantages puisque lorsqu''il est mal utilisé, des failles de sécurité peuvent apparaître.

Lors de mon second semestre à IN''TECH INFO, j''ai pu apprendre à utiliser ce langage. Son apprentissage fut un peu déconcertant au départ depart la flexibilité du langage (pas de typage, intégration facile dans une page web...). Couplé à un serveur de base de données MySQL, mon équipe et moi-même avons pu réaliser notre projet, Blog''On, un blog centré sur la simplicité d''utilisation. 

J''ai également pu l''utiliser lors de mon stage de découverte en entreprise. J''ai réalisé entièrement le développement de l''application MMD en PHP pour un client de http://www.cokoo.fr .

Enfin, j''ai développé un site communautaire pour une équipe de sport électronique, disponible à l''adresse : http://www.insight-gaming.fr .', 1, N'phplogo.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (3, N'Orchard', N'Orchard est un projet gratuit, open source, communautaire dont le but est de délivrer des applications et des composants réutilisables sur la plateforme ASP.NET. Tout comme d''autres CMS tels que WordPress et Joomla, il permet de créer et personnaliser un site web. Néanmoins, il a la particularité d''être très personnalisble non pas par son interface graphique mais par le code.
Sur Orchard, tout est module. L''ajout de fonctionnalités se fait par l''ajout de module. Et le code est fait de telle sorte que l''ajout d''un module soit le plus aisé possible. 
Orchard dispose également d''une communauté très active et les mises à jours du framework sont régulières.

Après un premier semestre passé à développer une première version du projet TiDoi en semestre 3, nous  nous sommes rapidement rendus compte que nous n''arriverions pas à terminer le projet. Après avoir étudié plusieurs solutions, nous avons découvert Orchard, CMS orienté vers la personnalisation par le développement et non par le "cliquodrome".

Après avoir pris le temps d''étudier Orchard, sa structure, les compétences nécessaires pour créer des modules, nous avons pu créer les notres. J''ai notamment créé un module permettant de mettre une note à n''importe quel élément de contenu.

Orchard nous a permis d''avoir un projet fonctionnel en un semestre.', 1, N'OrchardLogo.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (4, N'Les bases de données', N'Le SQL, alias Structured Query Language est un langage informatique normalisé servant à exploiter des bases de données relationnelles dans un SGBDR(système de gestion de base de données relationnelles).

Les SGBDR utilisant SQL ne manquent pas. Durant ma formation et mes diverses expériences professionnelles, j''ai pu en expérimenter deux : MySQL et SQL Server.

MySQL est un des SGBDR les plus utilisé au monde et souvent associé au PHP, bien qu''il soit supporté par la majorité des systèmes d''exploitations et compatibles avec les languages  de programmation les plus répandus.

J''ai pu faire connaissance avec les base de données relationnelles et plus particulièrement MySQL lors du projet BlogOn, un blog personnalisable à souhait.
Pour ce projet, nous avions besoin de stocker des informations concernant le contenu, les préférences des utilisateurs, les rôles et droits, les comptes... 
MySQL nous ayant été imposé, j''ai pu découvrir la syntaxe du SQL, le CRUD, les opérations complexes (les jointures et les sous-requêtes entre autres).

SQL Server est un produit appartenant à Microsoft. C''est un SGBDR transactionnel, utilisant le Transact-SQL pour les requêtes. 

J''ai pu toucher du doigt SQL Server lors de mes projets en C# à IN''TECH INFO.
Néanmoins, la base de données n''étant pas une de nos préoccupations principales lors de ces projets, j''ai réellement pu utiliser SQL Server lors de mon stage et de mon alternance à TalentSoft.
Sur des bases de production de plus de 200 tables, avec plusieurs schémas différents, j''ai eu l''occasion de faire de l''optimisation de requêtes (procédures stockées ou vues), de découvrir les triggers ou encore d''apprendre à utiliser SQL Server Management Studio.', 1, N'sqlserver.jpg')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (5, N'Gestion de versions : Git et SVN', N'GIT / SVN sont deux logiciels de gestion de version.', 1, N'Git.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (6, N'Développer en C', N'Cest compliqué mais cest bien', 1, N'c.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (8, N'HTML / CSS', N'Cest compliqué mais cest bien', 1, N'html.jpg')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (9, N'La communication', N'Cest compliqué mais cest bien', 2, N'communication.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (10, N'L''autonomie', N'Cest compliqué mais cest bien', 2, N'autonomie.jpg')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (11, N'L''anglais', N'Cest compliqué mais cest bien', 2, N'english.jpg')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (12, N'La gestion de projet', N'Cest compliqué mais cest bien', 2, N'project.png')
INSERT [dbo].[Competence] ([Id], [Name], [Description], [CompetenceType], [LogoUrl]) VALUES (13, N'La formation', N'Cest compliqué mais cest bien', 2, N'formation.jpg')
SET IDENTITY_INSERT [dbo].[Competence] OFF
/****** Object:  Table [dbo].[Realisation]    Script Date: 04/27/2015 16:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Realisation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [text] NULL,
	[LogoName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Realisation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Realisation] ON
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (1, N'TiDoi', N'Tidoi est un projet innovant et ayant un objectif bien réel. C''est un site web qui permet de comparer les bons plans concernant les activités tels que la restauration où les bars. Réalisé sur deux semestres, cela a été une vraie opportunité pour nous de démontrer notre savoir-faire et nos compétences que ce soit sur le plan technique ou humain. Ayant été chef de projet lors du premier semestre, j''ai pu me rendre compte des difficultés de la gestion d''une équipe ainsi que d''une vraie relation client.', N'TiDoi.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (2, N'MKS', N'Notre mission pour le semestre a été d''ajouter un module à 
			une solution existante, MKS. Ce dernier a pour but de faciliter la gestion
            d''IntechInfo. Notre module avait pour objectif de concevoir et développer un outil permettant, 
			à l''équipe pédagogique et administrative du groupe 
            ESIEA, d''alimenter et de gérer les catalogues de cours d''IN''TECH INFO et de l''ESIEA.', N'MKS.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (3, N'Web Academy', N'Pour ce projet de semestre 3, notre objectif a été de former les étudiants de 1er semestre d''INTECH INFO au HTML et au CSS.
            Le défi était de taille puisque leur apprentissage de ces technologies dépendait uniquement de nous. Nous leur avons donc dispensé quatre cours de 2h,
            alliant parties théoriques (à l''aide de présentations PowerPoint) et pratiques (TP sur leur poste). Pour les TPs, l''objectif était de réaliser une galerie photo qui évoluait au fil des cours. A l''aide de ce
            projet ''fil rouge'', les étudiants se rendaient mieux compte de leur propre évolution.', N'webacademy.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (4, N'BlogOn', N'Blog''On est un générateur de blogs. Il permet de créer et d''administrer son propre blog de manière autonome. Il est possible de 
            créer des utilisateurs/administrateurs, de leur donner des droits, créer des articles ,changer le style du blog, et bien d''autres choses.', N'blogon.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (5, N'Bubblebreaker', N'description', N'bubblebreaker.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (6, N'Intechoes', N'description', N'intechoes.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (7, N'KartCup', N'description', N'KartCup.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (8, N'Student Computer Experience', N'description', N'sce.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (9, N'TalentSoft - Formation Git', N'description', N'talentsoft.jpeg')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (10, N'TalentSoft - Correction de tickets', N'description', N'talentsoft.jpeg')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (11, N'TalentSoft - Amélioration des performances', N'description', N'talentsoft.jpeg')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (12, N'MMD', N'description', N'mmd.png')
INSERT [dbo].[Realisation] ([Id], [Name], [Description], [LogoName]) VALUES (13, N'Ce portfolio', N'description', N'portfolio.png')
SET IDENTITY_INSERT [dbo].[Realisation] OFF
/****** Object:  Table [dbo].[CompetenceByRealisation]    Script Date: 04/27/2015 16:33:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompetenceByRealisation](
	[CompetenceId] [int] NOT NULL,
	[RealisationId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CompetenceId] ASC,
	[RealisationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (1, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (1, 2)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (1, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (1, 11)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (1, 13)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (2, 4)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (2, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (3, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 2)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 4)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 11)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (4, 13)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 2)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 4)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 9)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (5, 13)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (6, 5)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (8, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (8, 4)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (8, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (8, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (8, 13)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 2)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 3)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 6)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 7)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 8)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 9)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 11)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (9, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (10, 4)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (10, 9)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (10, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (10, 11)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (10, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (10, 13)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (11, 10)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (11, 11)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (12, 1)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (12, 7)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (12, 8)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (12, 12)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (13, 3)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (13, 7)
INSERT [dbo].[CompetenceByRealisation] ([CompetenceId], [RealisationId]) VALUES (13, 9)
/****** Object:  ForeignKey [FK__Competenc__Compe__1920BF5C]    Script Date: 04/27/2015 16:33:18 ******/
ALTER TABLE [dbo].[CompetenceByRealisation]  WITH CHECK ADD FOREIGN KEY([CompetenceId])
REFERENCES [dbo].[Competence] ([Id])
GO
/****** Object:  ForeignKey [FK__Competenc__Reali__1A14E395]    Script Date: 04/27/2015 16:33:18 ******/
ALTER TABLE [dbo].[CompetenceByRealisation]  WITH CHECK ADD FOREIGN KEY([RealisationId])
REFERENCES [dbo].[Realisation] ([Id])
GO
