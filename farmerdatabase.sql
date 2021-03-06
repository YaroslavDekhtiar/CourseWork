-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Дек 22 2021 г., 14:15
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `farmerdatabase`
--

-- --------------------------------------------------------

--
-- Структура таблицы `plants_combinations`
--

CREATE TABLE `plants_combinations` (
  `first_plant` varchar(20) NOT NULL,
  `second_plant` varchar(20) NOT NULL,
  `mark` int(20) UNSIGNED NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `plants_combinations`
--

INSERT INTO `plants_combinations` (`first_plant`, `second_plant`, `mark`) VALUES
('Баклажан', 'Баклажан', 0),
('Баклажан', 'Буряк', 2),
('Баклажан', 'Гарбуз', 2),
('Баклажан', 'Горох', 2),
('Баклажан', 'Диня', 2),
('Баклажан', 'Кавун', 2),
('Баклажан', 'Капуста', 2),
('Баклажан', 'Кабачок', 2),
('Баклажан', 'Квасоля', 3),
('Баклажан', 'Картопля', 0),
('Баклажан', 'Кукурудза', 2),
('Баклажан', 'Морква', 2),
('Баклажан', 'Огірок', 2),
('Баклажан', 'Помідор', 0),
('Баклажан', 'Перець', 0),
('Баклажан', 'Пшениця', 2),
('Баклажан', 'Редис', 2),
('Баклажан', 'Ріпа', 2),
('Баклажан', 'Соя', 2),
('Баклажан', 'Цибуля', 2),
('Баклажан', 'Часник', 2),
('Баклажан', 'Ячмінь', 2),
('Буряк', 'Баклажан', 0),
('Буряк', 'Буряк', 0),
('Буряк', 'Гарбуз', 3),
('Буряк', 'Горох', 2),
('Буряк', 'Диня', 2),
('Буряк', 'Кавун', 2),
('Буряк', 'Капуста', 3),
('Буряк', 'Кабачок', 2),
('Буряк', 'Квасоля', 3),
('Буряк', 'Картопля', 1),
('Буряк', 'Кукурудза', 1),
('Буряк', 'Морква', 2),
('Буряк', 'Огірок', 3),
('Буряк', 'Помідор', 3),
('Буряк', 'Пшениця', 2),
('Буряк', 'Редис', 2),
('Буряк', 'Ріпа', 2),
('Буряк', 'Соя', 3),
('Буряк', 'Цибуля', 3),
('Буряк', 'Часник', 0),
('Буряк', 'Ячмінь', 2),
('Гарбуз', 'Баклажан', 2),
('Гарбуз', 'Буряк', 3),
('Гарбуз', 'Гарбуз', 0),
('Гарбуз', 'Горох', 2),
('Гарбуз', 'Диня', 0),
('Гарбуз', 'Кавун', 0),
('Гарбуз', 'Капуста', 3),
('Гарбуз', 'Кабачок', 0),
('Гарбуз', 'Квасоля', 2),
('Гарбуз', 'Картопля', 3),
('Гарбуз', 'Кукурудза', 3),
('Гарбуз', 'Морква', 0),
('Гарбуз', 'Огірок', 2),
('Гарбуз', 'Помідор', 3),
('Гарбуз', 'Перець', 3),
('Гарбуз', 'Пшениця', 2),
('Гарбуз', 'Редис', 3),
('Гарбуз', 'Ріпа', 3),
('Гарбуз', 'Соя', 3),
('Гарбуз', 'Цибуля', 3),
('Гарбуз', 'Часник', 3),
('Гарбуз', 'Ячмінь', 2),
('Горох', 'Баклажан', 3),
('Горох', 'Буряк', 2),
('Горох', 'Гарбуз', 2),
('Горох', 'Горох', 0),
('Горох', 'Диня', 2),
('Горох', 'Кавун', 2),
('Горох', 'Капуста', 1),
('Горох', 'Кабачок', 3),
('Горох', 'Квасоля', 1),
('Горох', 'Картопля', 2),
('Горох', 'Кукурудза', 1),
('Горох', 'Морква', 3),
('Горох', 'Огірок', 3),
('Горох', 'Помідор', 1),
('Горох', 'Перець', 2),
('Горох', 'Пшениця', 0),
('Горох', 'Редис', 3),
('Горох', 'Ріпа', 3),
('Горох', 'Соя', 0),
('Горох', 'Цибуля', 1),
('Горох', 'Часник', 0),
('Горох', 'Ячмінь', 0),
('Диня', 'Баклажан', 3),
('Диня', 'Буряк', 2),
('Диня', 'Гарбуз', 0),
('Диня', 'Горох', 2),
('Диня', 'Диня', 0),
('Диня', 'Кавун', 0),
('Диня', 'Капуста', 2),
('Диня', 'Кабачок', 0),
('Диня', 'Квасоля', 2),
('Диня', 'Картопля', 2),
('Диня', 'Кукурудза', 2),
('Диня', 'Морква', 0),
('Диня', 'Огірок', 0),
('Диня', 'Помідор', 3),
('Диня', 'Перець', 3),
('Диня', 'Пшениця', 2),
('Диня', 'Редис', 2),
('Диня', 'Ріпа', 2),
('Диня', 'Соя', 2),
('Диня', 'Цибуля', 0),
('Диня', 'Часник', 2),
('Диня', 'Ячмінь', 2),
('Кавун', 'Баклажан', 3),
('Кавун', 'Буряк', 2),
('Кавун', 'Гарбуз', 0),
('Кавун', 'Горох', 2),
('Кавун', 'Диня', 0),
('Кавун', 'Кавун', 0),
('Кавун', 'Капуста', 2),
('Кавун', 'Кабачок', 0),
('Кавун', 'Квасоля', 2),
('Кавун', 'Картопля', 2),
('Кавун', 'Кукурудза', 2),
('Кавун', 'Морква', 0),
('Кавун', 'Огірок', 0),
('Кавун', 'Помідор', 3),
('Кавун', 'Перець', 3),
('Кавун', 'Пшениця', 2),
('Кавун', 'Редис', 2),
('Кавун', 'Ріпа', 2),
('Кавун', 'Соя', 2),
('Кавун', 'Цибуля', 0),
('Кавун', 'Часник', 2),
('Кавун', 'Ячмінь', 2),
('Капуста', 'Баклажан', 3),
('Капуста', 'Буряк', 3),
('Капуста', 'Гарбуз', 2),
('Капуста', 'Горох', 1),
('Капуста', 'Диня', 2),
('Капуста', 'Кавун', 2),
('Капуста', 'Капуста', 0),
('Капуста', 'Кабачок', 2),
('Капуста', 'Квасоля', 3),
('Капуста', 'Картопля', 2),
('Капуста', 'Кукурудза', 2),
('Капуста', 'Морква', 2),
('Капуста', 'Огірок', 3),
('Капуста', 'Помідор', 1),
('Капуста', 'Перець', 3),
('Капуста', 'Пшениця', 2),
('Капуста', 'Редис', 0),
('Капуста', 'Ріпа', 3),
('Капуста', 'Соя', 2),
('Капуста', 'Цибуля', 1),
('Капуста', 'Часник', 0),
('Капуста', 'Ячмінь', 2),
('Кабачок', 'Баклажан', 2),
('Кабачок', 'Буряк', 2),
('Кабачок', 'Гарбуз', 0),
('Кабачок', 'Горох', 2),
('Кабачок', 'Диня', 0),
('Кабачок', 'Кавун', 0),
('Кабачок', 'Капуста', 3),
('Кабачок', 'Кабачок', 0),
('Кабачок', 'Квасоля', 2),
('Кабачок', 'Картопля', 1),
('Кабачок', 'Кукурудза', 3),
('Кабачок', 'Морква', 0),
('Кабачок', 'Огірок', 0),
('Кабачок', 'Помідор', 3),
('Кабачок', 'Перець', 2),
('Кабачок', 'Пшениця', 2),
('Кабачок', 'Редис', 2),
('Кабачок', 'Ріпа', 2),
('Кабачок', 'Соя', 3),
('Кабачок', 'Цибуля', 0),
('Кабачок', 'Часник', 2),
('Кабачок', 'Ячмінь', 2),
('Квасоля', 'Баклажан', 3),
('Квасоля', 'Буряк', 3),
('Квасоля', 'Гарбуз', 2),
('Квасоля', 'Горох', 1),
('Квасоля', 'Диня', 2),
('Квасоля', 'Кавун', 2),
('Квасоля', 'Капуста', 3),
('Квасоля', 'Кабачок', 2),
('Квасоля', 'Квасоля', 0),
('Квасоля', 'Картопля', 3),
('Квасоля', 'Кукурудза', 3),
('Квасоля', 'Морква', 2),
('Квасоля', 'Огірок', 3),
('Квасоля', 'Помідор', 3),
('Квасоля', 'Перець', 3),
('Квасоля', 'Пшениця', 2),
('Квасоля', 'Редис', 3),
('Квасоля', 'Ріпа', 2),
('Квасоля', 'Соя', 0),
('Квасоля', 'Цибуля', 1),
('Квасоля', 'Часник', 1),
('Квасоля', 'Ячмінь', 2),
('Картопля', 'Баклажан', 0),
('Картопля', 'Буряк', 1),
('Картопля', 'Гарбуз', 3),
('Картопля', 'Горох', 1),
('Картопля', 'Диня', 3),
('Картопля', 'Кавун', 3),
('Картопля', 'Капуста', 2),
('Картопля', 'Кабачок', 1),
('Картопля', 'Квасоля', 3),
('Картопля', 'Картопля', 0),
('Картопля', 'Кукурудза', 0),
('Картопля', 'Морква', 2),
('Картопля', 'Огірок', 1),
('Картопля', 'Помідор', 0),
('Картопля', 'Перець', 0),
('Картопля', 'Пшениця', 3),
('Картопля', 'Редис', 2),
('Картопля', 'Ріпа', 1),
('Картопля', 'Соя', 3),
('Картопля', 'Цибуля', 2),
('Картопля', 'Часник', 2),
('Картопля', 'Ячмінь', 3),
('Кукурудза', 'Баклажан', 2),
('Кукурудза', 'Буряк', 1),
('Кукурудза', 'Гарбуз', 3),
('Кукурудза', 'Горох', 3),
('Кукурудза', 'Диня', 2),
('Кукурудза', 'Кавун', 2),
('Кукурудза', 'Капуста', 2),
('Кукурудза', 'Кабачок', 3),
('Кукурудза', 'Квасоля', 3),
('Кукурудза', 'Картопля', 0),
('Кукурудза', 'Кукурудза', 0),
('Кукурудза', 'Морква', 2),
('Кукурудза', 'Огірок', 3),
('Кукурудза', 'Помідор', 3),
('Кукурудза', 'Перець', 2),
('Кукурудза', 'Пшениця', 0),
('Кукурудза', 'Редис', 2),
('Кукурудза', 'Ріпа', 2),
('Кукурудза', 'Соя', 2),
('Кукурудза', 'Цибуля', 2),
('Кукурудза', 'Часник', 2),
('Кукурудза', 'Ячмінь', 0),
('Морква', 'Баклажан', 0),
('Морква', 'Буряк', 2),
('Морква', 'Гарбуз', 3),
('Морква', 'Горох', 3),
('Морква', 'Диня', 2),
('Морква', 'Кавун', 2),
('Морква', 'Капуста', 3),
('Морква', 'Кабачок', 3),
('Морква', 'Квасоля', 2),
('Морква', 'Картопля', 2),
('Морква', 'Кукурудза', 2),
('Морква', 'Морква', 0),
('Морква', 'Огірок', 0),
('Морква', 'Помідор', 3),
('Морква', 'Перець', 2),
('Морква', 'Пшениця', 2),
('Морква', 'Редис', 2),
('Морква', 'Ріпа', 2),
('Морква', 'Соя', 2),
('Морква', 'Цибуля', 3),
('Морква', 'Часник', 0),
('Морква', 'Ячмінь', 2),
('Огірок', 'Баклажан', 2),
('Огірок', 'Буряк', 3),
('Огірок', 'Гарбуз', 2),
('Огірок', 'Горох', 3),
('Огірок', 'Диня', 0),
('Огірок', 'Кавун', 0),
('Огірок', 'Капуста', 2),
('Огірок', 'Кабачок', 0),
('Огірок', 'Квасоля', 3),
('Огірок', 'Картопля', 1),
('Огірок', 'Кукурудза', 3),
('Огірок', 'Морква', 2),
('Огірок', 'Огірок', 0),
('Огірок', 'Помідор', 1),
('Огірок', 'Перець', 2),
('Огірок', 'Пшениця', 2),
('Огірок', 'Ріпа', 2),
('Огірок', 'Редис', 3),
('Огірок', 'Соя', 3),
('Огірок', 'Цибуля', 3),
('Огірок', 'Часник', 2),
('Огірок', 'Ячмінь', 2),
('Помідор', 'Баклажан', 0),
('Помідор', 'Буряк', 3),
('Помідор', 'Гарбуз', 2),
('Помідор', 'Горох', 0),
('Помідор', 'Диня', 3),
('Помідор', 'Кавун', 3),
('Помідор', 'Капуста', 1),
('Помідор', 'Кабачок', 2),
('Помідор', 'Квасоля', 3),
('Помідор', 'Картопля', 1),
('Помідор', 'Кукурудза', 3),
('Помідор', 'Морква', 3),
('Помідор', 'Огірок', 1),
('Помідор', 'Помідор', 0),
('Помідор', 'Перець', 0),
('Помідор', 'Пшениця', 2),
('Помідор', 'Редис', 3),
('Помідор', 'Ріпа', 3),
('Помідор', 'Соя', 3),
('Помідор', 'Цибуля', 3),
('Помідор', 'Часник', 2),
('Помідор', 'Ячмінь', 2),
('Перець', 'Баклажан', 0),
('Перець', 'Буряк', 1),
('Перець', 'Гарбуз', 3),
('Перець', 'Горох', 2),
('Перець', 'Диня', 1),
('Перець', 'Кавун', 1),
('Перець', 'Капуста', 2),
('Перець', 'Кабачок', 1),
('Перець', 'Квасоля', 2),
('Перець', 'Картопля', 0),
('Перець', 'Кукурудза', 2),
('Перець', 'Морква', 1),
('Перець', 'Огірок', 1),
('Перець', 'Помідор', 0),
('Перець', 'Перець', 0),
('Перець', 'Пшениця', 2),
('Перець', 'Редис', 1),
('Перець', 'Ріпа', 1),
('Перець', 'Соя', 2),
('Перець', 'Цибуля', 1),
('Перець', 'Часник', 1),
('Перець', 'Ячмінь', 2),
('Пшениця', 'Баклажан', 3),
('Пшениця', 'Буряк', 3),
('Пшениця', 'Гарбуз', 2),
('Пшениця', 'Горох', 2),
('Пшениця', 'Диня', 3),
('Пшениця', 'Кавун', 3),
('Пшениця', 'Капуста', 3),
('Пшениця', 'Кабачок', 2),
('Пшениця', 'Квасоля', 3),
('Пшениця', 'Картопля', 3),
('Пшениця', 'Кукурудза', 0),
('Пшениця', 'Морква', 3),
('Пшениця', 'Огірок', 2),
('Пшениця', 'Помідор', 3),
('Пшениця', 'Перець', 2),
('Пшениця', 'Пшениця', 0),
('Пшениця', 'Редис', 3),
('Пшениця', 'Ріпа', 3),
('Пшениця', 'Соя', 2),
('Пшениця', 'Цибуля', 3),
('Пшениця', 'Часник', 3),
('Пшениця', 'Ячмінь', 0),
('Редис', 'Баклажан', 2),
('Редис', 'Буряк', 2),
('Редис', 'Гарбуз', 2),
('Редис', 'Горох', 3),
('Редис', 'Диня', 2),
('Редис', 'Кавун', 2),
('Редис', 'Капуста', 0),
('Редис', 'Кабачок', 2),
('Редис', 'Квасоля', 3),
('Редис', 'Картопля', 3),
('Редис', 'Кукурудза', 2),
('Редис', 'Морква', 2),
('Редис', 'Огірок', 3),
('Редис', 'Помідор', 3),
('Редис', 'Перець', 2),
('Редис', 'Пшениця', 2),
('Редис', 'Редис', 0),
('Редис', 'Ріпа', 0),
('Редис', 'Соя', 2),
('Редис', 'Цибуля', 0),
('Редис', 'Часник', 2),
('Редис', 'Ячмінь', 2),
('Ріпа', 'Баклажан', 2),
('Ріпа', 'Буряк', 2),
('Ріпа', 'Гарбуз', 2),
('Ріпа', 'Горох', 3),
('Ріпа', 'Диня', 2),
('Ріпа', 'Кавун', 2),
('Ріпа', 'Капуста', 3),
('Ріпа', 'Кабачок', 2),
('Ріпа', 'Квасоля', 2),
('Ріпа', 'Картопля', 1),
('Ріпа', 'Кукурудза', 2),
('Ріпа', 'Морква', 2),
('Ріпа', 'Огірок', 2),
('Ріпа', 'Помідор', 3),
('Ріпа', 'Перець', 2),
('Ріпа', 'Пшениця', 2),
('Ріпа', 'Редис', 0),
('Ріпа', 'Ріпа', 0),
('Ріпа', 'Соя', 2),
('Ріпа', 'Цибуля', 0),
('Ріпа', 'Цибуля', 2),
('Ріпа', 'Часник', 2),
('Соя', 'Баклажан', 3),
('Соя', 'Буряк', 2),
('Соя', 'Гарбуз', 3),
('Соя', 'Горох', 0),
('Соя', 'Диня', 2),
('Соя', 'Кавун', 2),
('Соя', 'Капуста', 3),
('Соя', 'Кабачок', 3),
('Соя', 'Квасоля', 0),
('Соя', 'Картопля', 3),
('Соя', 'Кукурудза', 0),
('Соя', 'Морква', 2),
('Соя', 'Огірок', 3),
('Соя', 'Помідор', 2),
('Соя', 'Перець', 3),
('Соя', 'Пшениця', 0),
('Соя', 'Редис', 2),
('Соя', 'Ріпа', 2),
('Соя', 'Соя', 0),
('Соя', 'Цибуля', 2),
('Соя', 'Часник', 2),
('Соя', 'Ячмінь', 0),
('Цибуля', 'Баклажан', 2),
('Цибуля', 'Буряк', 3),
('Цибуля', 'Гарбуз', 3),
('Цибуля', 'Горох', 1),
('Цибуля', 'Диня', 3),
('Цибуля', 'Кавун', 3),
('Цибуля', 'Капуста', 1),
('Цибуля', 'Кабачок', 3),
('Цибуля', 'Квасоля', 1),
('Цибуля', 'Картопля', 3),
('Цибуля', 'Кукурудза', 2),
('Цибуля', 'Морква', 3),
('Цибуля', 'Огірок', 2),
('Цибуля', 'Помідор', 3),
('Цибуля', 'Перець', 3),
('Цибуля', 'Пшениця', 2),
('Цибуля', 'Редис', 3),
('Пшениця', 'Ріпа', 3),
('Цибуля', 'Ріпа', 3),
('Цибуля', 'Соя', 3),
('Цибуля', 'Цибуля', 0),
('Цибуля', 'Часник', 0),
('Цибуля', 'Ячмінь', 2),
('Часник', 'Баклажан', 2),
('Часник', 'Буряк', 2),
('Часник', 'Гарбуз', 2),
('Часник', 'Горох', 0),
('Часник', 'Диня', 2),
('Часник', 'Кавун', 2),
('Часник', 'Капуста', 0),
('Часник', 'Кабачок', 2),
('Часник', 'Квасоля', 1),
('Часник', 'Картопля', 2),
('Часник', 'Кукурудза', 2),
('Часник', 'Морква', 2),
('Часник', 'Огірок', 2),
('Часник', 'Помідор', 2),
('Часник', 'Перець', 2),
('Часник', 'Пшениця', 2),
('Часник', 'Редис', 2),
('Часник', 'Ріпа', 2),
('Часник', 'Соя', 2),
('Часник', 'Цибуля', 0),
('Часник', 'Часник', 0),
('Часник', 'Ячмінь', 2),
('Ячмінь', 'Баклажан', 3),
('Ячмінь', 'Буряк', 3),
('Ячмінь', 'Гарбуз', 2),
('Ячмінь', 'Горох', 2),
('Ячмінь', 'Диня', 3),
('Ячмінь', 'Кавун', 3),
('Ячмінь', 'Капуста', 3),
('Ячмінь', 'Кабачок', 2),
('Ячмінь', 'Квасоля', 3),
('Ячмінь', 'Картопля', 3),
('Ячмінь', 'Кукурудза', 0),
('Ячмінь', 'Морква', 3),
('Ячмінь', 'Огірок', 2),
('Ячмінь', 'Помідор', 3),
('Ячмінь', 'Перець', 2),
('Ячмінь', 'Пшениця', 0),
('Ячмінь', 'Редис', 3),
('Ячмінь', 'Ріпа', 3),
('Ячмінь', 'Соя', 2),
('Ячмінь', 'Цибуля', 3),
('Ячмінь', 'Часник', 3),
('Ячмінь', 'Ячмінь', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(32) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `login`, `password`) VALUES
(1, 'Admin', '1111'),
(2, 'ADMIN', '1234');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
