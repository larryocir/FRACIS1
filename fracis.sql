-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 14, 2021 at 12:38 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fracis`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `acc_id` int(11) NOT NULL,
  `acc_uname` varchar(20) NOT NULL,
  `acc_password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`acc_id`, `acc_uname`, `acc_password`) VALUES
(1, 'ADMIN', 'ADMIN');

-- --------------------------------------------------------

--
-- Table structure for table `animal`
--

CREATE TABLE `animal` (
  `animal_id` int(11) NOT NULL,
  `animal_type` varchar(30) NOT NULL,
  `animal_cat` varchar(100) NOT NULL,
  `animal_no` int(11) NOT NULL,
  `mem_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `animal`
--

INSERT INTO `animal` (`animal_id`, `animal_type`, `animal_cat`, `animal_no`, `mem_id`) VALUES
(1, 'Swine', 'Livestock', 1, 1),
(2, 'Carabao', 'Livestock', 2, 2),
(3, 'Cattle', 'Livestock', 4, 2),
(4, 'Swine', 'Livestock', 10, 2),
(5, 'Goat', 'Livestock', 8, 2),
(6, 'Chicken', 'Poultry', 20, 2),
(7, 'Duck', 'Poultry', 20, 2),
(8, 'Goose', 'Poultry', 10, 2),
(9, 'Swine', 'Livestock', 6, 3),
(10, 'Chicken', 'Poultry', 10, 3),
(11, 'Dog', 'Other Animals', 2, 3),
(12, 'Chicken', 'Poultry', 8, 4),
(13, 'Duck', 'Poultry', 2, 4);

-- --------------------------------------------------------

--
-- Table structure for table `crops`
--

CREATE TABLE `crops` (
  `crops_id` int(11) NOT NULL,
  `crops_type` varchar(50) NOT NULL,
  `crops_cat` varchar(50) NOT NULL,
  `crops_landarea` decimal(11,2) NOT NULL,
  `mem_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `crops`
--

INSERT INTO `crops` (`crops_id`, `crops_type`, `crops_cat`, `crops_landarea`, `mem_id`) VALUES
(1, 'Vegetables', 'HVCDP', '1.30', 1),
(2, 'Rice', 'Rice', '1.00', 2),
(3, 'Vegetables', 'HVCDP', '0.60', 2),
(4, 'Rice', 'Rice', '1.50', 3),
(5, 'Coconut', 'Coconut', '0.40', 3),
(6, 'Vegetables', 'HVCDP', '1.60', 3),
(7, 'Coconut', 'Coconut', '1.50', 4),
(8, 'Vegetables', 'HVCDP', '2.50', 4),
(9, 'Root Crops', 'HVCDP', '0.50', 4);

-- --------------------------------------------------------

--
-- Table structure for table `distributed`
--

CREATE TABLE `distributed` (
  `distributed_id` int(11) NOT NULL,
  `distributed_item` varchar(255) NOT NULL,
  `distributed_venue` varchar(255) NOT NULL,
  `distributed_date` date NOT NULL,
  `mem_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `farm_profile`
--

CREATE TABLE `farm_profile` (
  `farm_id` int(11) NOT NULL,
  `farm_location` varchar(255) NOT NULL,
  `farm_type` varchar(100) NOT NULL,
  `farm_area` decimal(11,2) NOT NULL,
  `farm_ownertype` varchar(50) NOT NULL,
  `farm_owner` varchar(50) NOT NULL,
  `farm_boundary_north` varchar(255) NOT NULL,
  `farm_boundary_south` varchar(255) NOT NULL,
  `farm_boundary_east` varchar(255) NOT NULL,
  `farm_boundary_west` varchar(255) NOT NULL,
  `mem_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `farm_profile`
--

INSERT INTO `farm_profile` (`farm_id`, `farm_location`, `farm_type`, `farm_area`, `farm_ownertype`, `farm_owner`, `farm_boundary_north`, `farm_boundary_south`, `farm_boundary_east`, `farm_boundary_west`, `mem_id`) VALUES
(1, 'SAGRADA FAMILIA', 'Rainfed Upland', '1.30', 'Register Ownership', '', 'PEPITO PROPERTY', 'DELA CRUZ', 'MANALOTO', 'JUAN', 1),
(2, 'MANGGA', 'Irregated', '1.60', 'Register Ownership', '', '', '', '', '', 2),
(3, 'CALAGBANGAN', 'Rainfed Lowland', '3.60', 'Register Ownership', '', '', '', '', '', 3),
(4, 'SALVACION', 'Irregated', '4.50', 'Register Ownership', '', '', '', '', '', 4);

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE `member` (
  `mem_id` int(11) NOT NULL,
  `mem_system_generated_rsbsa_no` varchar(100) NOT NULL,
  `mem_rsbsa_no` varchar(100) NOT NULL,
  `mem_fname` varchar(50) NOT NULL,
  `mem_lname` varchar(50) NOT NULL,
  `mem_mname` varchar(50) NOT NULL,
  `mem_extname` varchar(10) NOT NULL,
  `mem_barangay` varchar(100) NOT NULL,
  `mem_municipality` varchar(100) NOT NULL,
  `mem_province` varchar(100) NOT NULL,
  `mem_dob` varchar(30) NOT NULL,
  `mem_pob` varchar(255) NOT NULL,
  `mem_sex` varchar(10) NOT NULL,
  `mem_cp` varchar(20) NOT NULL,
  `mem_civilstatus` varchar(11) NOT NULL,
  `mem_spouse` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`mem_id`, `mem_system_generated_rsbsa_no`, `mem_rsbsa_no`, `mem_fname`, `mem_lname`, `mem_mname`, `mem_extname`, `mem_barangay`, `mem_municipality`, `mem_province`, `mem_dob`, `mem_pob`, `mem_sex`, `mem_cp`, `mem_civilstatus`, `mem_spouse`) VALUES
(1, '05-17-34-033-000001', '05-17-34-000059', 'ROSIE', 'LOPEZ', 'ESCOVER', '', 'SAGRADA FAMILIA', 'SIPOCOT', 'CAMARINES SUR', '1951-09-05', 'SAGRADA FAMILIA', 'Female', '09296440531', 'Widowed', ''),
(2, '05-17-34-028-000001', '', 'MARIA GINA', 'BOMBALES', 'CANDELARIA', '', 'MANGGA', 'SIPOCOT', 'CAMARINES SUR', '1970-03-12', 'MANGGA', 'Female', '09073100069', 'Married', ''),
(3, '05-17-34-014-000001', '', 'JULIANA', 'MASOTES', 'ALDAY', '', 'CALAGBANGAN', 'SIPOCOT', 'CAMARINES SUR', '1968-02-16', '', 'Female', '0929578759', 'Married', ''),
(4, '05-17-34-035-000001', '', 'ELMUNDO', 'DELA TRINIDAD', 'RODREGUEZ', '', 'SALVACION', 'SIPOCOT', 'CAMARINES SUR', '1947-10-22', '', 'Male', '09485195049', 'Widowed', '');

-- --------------------------------------------------------

--
-- Table structure for table `tbldata`
--

CREATE TABLE `tbldata` (
  `dat_ID` int(11) NOT NULL,
  `dat_LNAME` varchar(50) NOT NULL,
  `dat_FNAME` varchar(50) NOT NULL,
  `dat_BDAY` varchar(20) NOT NULL,
  `dat_AGE` varchar(20) NOT NULL,
  `dat_GENDER` char(10) NOT NULL,
  `dat_ADDRESS` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbldata`
--

INSERT INTO `tbldata` (`dat_ID`, `dat_LNAME`, `dat_FNAME`, `dat_BDAY`, `dat_AGE`, `dat_GENDER`, `dat_ADDRESS`) VALUES
(1, 'James', 'SMITH', '12/09/2015', '5', 'Male', 'Impig'),
(2, 'Robert', 'JOHNSON', '13/09/2015', '6', 'Female', 'Serranzana'),
(3, 'John', 'WILLIAMS', '14/09/2015', '7', 'Male', 'North Centro'),
(4, 'Michael', 'BROWN', '15/09/2015', '8', 'Female', 'Impig'),
(5, 'William', 'JONES', '16/09/2015', '9', 'Male', 'Serranzana'),
(6, 'David', 'GARCIA', '17/09/2015', '10', 'Female', 'North Centro'),
(7, 'Richard', 'MILLER', '18/09/2015', '11', 'Male', 'Impig'),
(8, 'Joseph', 'DAVIS', '19/09/2015', '12', 'Female', 'Serranzana'),
(9, 'Thomas', 'RODRIGUEZ', '20/09/2015', '13', 'Male', 'North Centro'),
(10, 'Charles', 'MARTINEZ', '21/09/2015', '14', 'Female', 'Impig'),
(11, 'Christopher', 'HERNANDEZ', '22/09/2015', '15', 'Male', 'Serranzana'),
(12, 'Daniel', 'LOPEZ', '23/09/2015', '16', 'Female', 'North Centro'),
(13, 'Matthew', 'GONZALEZ', '24/09/2015', '17', 'Male', 'Impig');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`acc_id`);

--
-- Indexes for table `animal`
--
ALTER TABLE `animal`
  ADD PRIMARY KEY (`animal_id`);

--
-- Indexes for table `crops`
--
ALTER TABLE `crops`
  ADD PRIMARY KEY (`crops_id`);

--
-- Indexes for table `distributed`
--
ALTER TABLE `distributed`
  ADD PRIMARY KEY (`distributed_id`);

--
-- Indexes for table `farm_profile`
--
ALTER TABLE `farm_profile`
  ADD PRIMARY KEY (`farm_id`);

--
-- Indexes for table `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`mem_id`);

--
-- Indexes for table `tbldata`
--
ALTER TABLE `tbldata`
  ADD PRIMARY KEY (`dat_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `acc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `animal`
--
ALTER TABLE `animal`
  MODIFY `animal_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `crops`
--
ALTER TABLE `crops`
  MODIFY `crops_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `distributed`
--
ALTER TABLE `distributed`
  MODIFY `distributed_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `farm_profile`
--
ALTER TABLE `farm_profile`
  MODIFY `farm_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `member`
--
ALTER TABLE `member`
  MODIFY `mem_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbldata`
--
ALTER TABLE `tbldata`
  MODIFY `dat_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
