<!DOCTYPE html>
<head>
    <title>Encargados</title>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">	
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
</head>
<body>
<nav class="navbar navbar-dark bg-dark">
                    <!-- Navbar content -->
                    <div class="container-fluid">
                    <a class="navbar-brand" href="Tienda.php">Inicio</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                    </button>
                    <div class="collapse navbar-collapse" id="navbarText">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                            <a class="nav-link active" aria-current="page" href="Productos.php">Listado productos</a>
                            </li>
                            <li class="nav-item">
                            <a class="nav-link" href="Encargados.php">Listado Encargados</a>
                            </li>
                            <li class="nav-item">
                            <a class="nav-link" href="Ventas.php">Registo ventas</a>
                            </li>
                            <li class="nav-item">
                            <a class="nav-link" href="https://youtu.be/dQw4w9WgXcQ">:)</a>
                            </li>
                    </ul>
                    <span class="navbar-text">
                            
                    </span>
                    </div>
                    </div>
            </nav>
            <br>
            <center><h1>Listado Encargados</h1></center>
            <br>
            <div class="container-sm">
    <?php
    $user = "root";
    $pass = "";
    $host = "localhost";
    $connection = mysqli_connect($host, $user, $pass); 
    if(!$connection) 
            {
                echo "No se ha podido conectar con el servidor" . mysql_error();
            }
    $DB = "tienda";
    $dbselect = mysqli_select_db($connection,$DB);
    if (!$dbselect)
    {
    echo "No se ha podido encontrar la Base de Datos";
    }
    else
    $consulta = "SELECT id_encargado as 'ID', nombre_encargado as 'Nombre', tel_encargado as 'Teléfono', cui_encargado AS 'CUI' from encargado;";
    $result = mysqli_query($connection,$consulta);
    if(!$result) 
    {
        echo "No se ha podido realizar la consulta";
    };
    echo '<table class="table table-dark table-borderless">';
    echo "<tr>";
    echo '<th scope = "col"><h4>ID</th></h4>';
    echo '<th scope = "col"><h4>Nombre</th></h4>';
    echo '<th scope = "col"><h4>Teléfono</th></h4>';
    echo '<th scope = "col"><h4>CUI</th></h4>';
    echo "</tr>";
    while ($colum = mysqli_fetch_array($result))
    {
        echo "<tr>";
        echo "<td>" . $colum['ID']. "</td>";
        echo "<td>" . $colum['Nombre'] . "</td>";
        echo "<td>" . $colum['Teléfono'] . "</td>";
        echo "<td>" . $colum['CUI'] . "</td>";
        echo "</tr>";
    }
    echo "</table>"; ?>
            </body>
</html>