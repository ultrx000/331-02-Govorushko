<?php
    require_once('db1.php');

$login = $_POST['login'];
$pass = $_POST['pass'];

if (empty($login) || empty($pass)) {
    echo "Заполните все поля";
} else {
    $sql = "SELECT * FROM `users` WHERE login = '$login' AND pass = '$pass'"; // Исправлена ошибка в SQL-запросе
    $result = $conn->query($sql);

    if ($result->num_rows > 0) { 
        while ($row = $result->fetch_assoc()) {
            echo "Добро пожаловать, " . $row["login"];
        }
    } else {
        echo "Нет такого пользователя";
    }
}
?>