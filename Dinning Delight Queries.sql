-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql12.freemysqlhosting.net
-- Generation Time: Jan 04, 2021 at 07:12 PM
-- Server version: 5.5.62-0ubuntu0.14.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql12384468`
--

-- --------------------------------------------------------

--
-- Table structure for table `Orders`
--

CREATE TABLE `Orders` (
  `OrderNumber` text NOT NULL,
  `ClientName` text NOT NULL,
  `OrderNameQuantity` text NOT NULL,
  `Bill` decimal(10,0) NOT NULL,
  `Date` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Orders`
--

INSERT INTO `Orders` (`OrderNumber`, `ClientName`, `OrderNameQuantity`, `Bill`, `Date`) VALUES
('@OrderNumber', '@ClientName', '@OrderNameQuantity', '0', '@TransactionDate'),
('DD-5160221-2846', 'Ahsan', 'Chicken Tikka (1 Plate) ,  || 5 ,', '1334', '1/1/2021'),
('DD-9797017-6949', 'HANIA', 'Chicken Tikka (1 Plate) , BBQ Tikka (1 Plate) ,  || 5 , 5 ,', '2378', 'Friday, January 1, 2021'),
('DD-4092856-1928', 'Ahsan', 'Chicken Tikka (1 Plate) , BBQ Tikka (1 Plate) ,  || 5 , 5 ,', '2378', 'Friday, January 1, 2021');

-- --------------------------------------------------------

--
-- Table structure for table `Products`
--

CREATE TABLE `Products` (
  `ID` int(11) NOT NULL,
  `ProductName` text NOT NULL,
  `ProductPrice` decimal(10,0) NOT NULL,
  `IsActive` tinyint(1) NOT NULL,
  `Stock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `Products`
--

INSERT INTO `Products` (`ID`, `ProductName`, `ProductPrice`, `IsActive`, `Stock`) VALUES
(1, 'Chicken Tikka (1 Plate)', '230', 1, 130),
(2, 'BBQ Tikka (1 Plate)', '180', 1, 80);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `Products`
--
ALTER TABLE `Products`
  ADD UNIQUE KEY `ID` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
