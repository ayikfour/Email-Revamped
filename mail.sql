-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 02, 2018 at 02:09 AM
-- Server version: 10.1.35-MariaDB
-- PHP Version: 7.2.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mail`
--

-- --------------------------------------------------------

--
-- Table structure for table `author`
--

CREATE TABLE `author` (
  `id` int(10) NOT NULL,
  `name` varchar(255) NOT NULL,
  `mail_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `author`
--

INSERT INTO `author` (`id`, `name`, `mail_name`, `password`) VALUES
(1, 'ayikfour', 'ayikfour4@mail', '111'),
(2, 'john doe', 'johndoe@mail', '111');

-- --------------------------------------------------------

--
-- Table structure for table `draft`
--

CREATE TABLE `draft` (
  `id` int(10) NOT NULL,
  `author_id` int(10) NOT NULL,
  `sender` varchar(255) NOT NULL,
  `recipient` varchar(255) NOT NULL,
  `subject` varchar(255) NOT NULL,
  `body` varchar(8000) NOT NULL,
  `created` datetime NOT NULL,
  `parent_id` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inbox`
--

CREATE TABLE `inbox` (
  `id` int(10) NOT NULL,
  `author_id` int(10) NOT NULL,
  `sender` varchar(255) NOT NULL,
  `recipient` varchar(255) NOT NULL,
  `subject` varchar(255) NOT NULL,
  `body` varchar(8000) NOT NULL,
  `created` datetime NOT NULL,
  `parent_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inbox`
--

INSERT INTO `inbox` (`id`, `author_id`, `sender`, `recipient`, `subject`, `body`, `created`, `parent_id`) VALUES
(11, 1, 'ayikfour4@mail', 'johndoe@mail', 'Finally!', 'it seems everything set up perfectly. just text me back if you found another bug.\n\nthanks!', '2018-10-02 00:54:00', '0');

-- --------------------------------------------------------

--
-- Table structure for table `outbox`
--

CREATE TABLE `outbox` (
  `id` int(10) NOT NULL,
  `author_id` int(10) NOT NULL,
  `sender` varchar(255) NOT NULL,
  `recipient` varchar(255) NOT NULL,
  `subject` varchar(255) NOT NULL,
  `body` varchar(8000) NOT NULL,
  `created` datetime NOT NULL,
  `parent_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `outbox`
--

INSERT INTO `outbox` (`id`, `author_id`, `sender`, `recipient`, `subject`, `body`, `created`, `parent_id`) VALUES
(2, 2, 'johndoe@mail', 'johndoe@mail', 'im texting myself!', 'wow, this is useless.', '2018-10-01 01:27:20', '0'),
(7, 2, 'johndoe@mail', 'ayikfour4@mail', 'Testing delete again', 'Oh hello, this delete feature still buggy sometimes.', '2018-10-02 00:35:19', '0'),
(8, 2, 'johndoe@mail', 'ayikfour4@mail', 'Test Delete', 'This feature still Buggy', '2018-10-02 00:38:06', '0'),
(13, 1, 'ayikfour4@mail', 'johndoe@mail', 'Testing Index', 'Test', '2018-10-02 00:50:33', '0'),
(14, 1, 'ayikfour4@mail', 'johndoe@mail', 'Finally!', 'it seems everything set up perfectly. just text me back if you found another bug.\n\nthanks!', '2018-10-02 00:54:00', '0');

-- --------------------------------------------------------

--
-- Table structure for table `trash`
--

CREATE TABLE `trash` (
  `id` int(10) NOT NULL,
  `author_id` int(10) NOT NULL,
  `sender` varchar(255) NOT NULL,
  `recipient` varchar(255) NOT NULL,
  `subject` varchar(255) NOT NULL,
  `body` varchar(8000) NOT NULL,
  `created` datetime NOT NULL,
  `parent_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `trash`
--

INSERT INTO `trash` (`id`, `author_id`, `sender`, `recipient`, `subject`, `body`, `created`, `parent_id`) VALUES
(5, 1, 'ayikfour4@mail', 'johndoe@mail', 'Delete Message', 'Im testing to delete some message', '0000-00-00 00:00:00', '0'),
(7, 1, 'ayikfour4@mail', 'johndoe@mail', 'SS', 'askdjalskdlkasjdkasdlkasjdlkasd', '2018-10-01 09:55:51', '0'),
(9, 1, 'ayikfour4@mail', 'johndoe@mail', 'Henlo!', 'Hello my brother john!', '2018-10-01 01:23:57', '0'),
(12, 2, 'johndoe@mail', 'ayikfour4@mail', 'Holla, Seems it is been fixed', 'test', '2018-10-02 00:40:40', '0'),
(19, 2, 'ayikfour4@mail', 'johndoe@mail', 'Testing Index', 'Test', '0000-00-00 00:00:00', '0');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `author`
--
ALTER TABLE `author`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `draft`
--
ALTER TABLE `draft`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inbox`
--
ALTER TABLE `inbox`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `outbox`
--
ALTER TABLE `outbox`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `trash`
--
ALTER TABLE `trash`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `author`
--
ALTER TABLE `author`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `draft`
--
ALTER TABLE `draft`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `inbox`
--
ALTER TABLE `inbox`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT for table `outbox`
--
ALTER TABLE `outbox`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `trash`
--
ALTER TABLE `trash`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
