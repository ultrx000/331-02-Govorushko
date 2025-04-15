<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Form register</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="">
    </head>
    <body>
        <form action="register.php" method="post">
            <input type="text" placeholder="login" name="login">
            <input type="text" placeholder="password" name="pass">
            <input type="text" placeholder="repeat password" name="repeatpass">
            <input type="text" placeholder="email" name="email">
            <button type="submit">Зарегестрироваться</button>
        </form>

        <form action="login.php" method="post">
            <input type="text" placeholder="login" name="login">
            <input type="text" placeholder="password" name="pass">
            <button type="submit">Войти</button>
        </form>

    </body>
</html>