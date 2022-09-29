<!DOCTYPE html>
<head>
    <title>Tienda</title>
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
            <nav class="navbar navbar-dark bg-light ">
        <div class="container-fluid text-dark">
            <a class="navbar-brand" href="#">
            <img src="Logo CVO.png" alt="" width="30" height="24" class="d-inline-block align-text-top">
            <span class="text-dark">Catalogo Productos</span>
        </a>
  </div>
    </nav>
    <h1 class="display-1 text-center"> Catálogo Productos </h1>
    <br>
    <center>
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="https://www.delipavo.com/wp-content/uploads/2022/03/jamon-de-pavo-cocido.jpg" alt="Robotica">
                    <div class="card-body">
                        <h5 class="card-title">Jamón de pavo</h5>
                        <p class="card-text">La carne del pavo es fuente de proteínas, vitaminas del grupo del complejo B como la B1, B3, B5, B6, biotina, B12 y el ácido fólico, y de minerales como el fósforo, el potasio, el magnesio, el hierro y el cinc.</p>
                                             </div>
                </div>
            </div>
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="https://cdn.foodandwineespanol.com/2018/10/beef-close-up-delicious-357576.jpg" alt="Impresion 3D">
                    <div class="card-body">
                        <h5 class="card-title">Salchichas</h5>
                        <p class="card-text">Una ventaja de este tipo de alimentos es que son ricos en proteínas, vitaminas y minerales esenciales absorbibles, como el hierro, el zinc y la vitamina B12. Encontramos también selenio, colina, vitamina B6, tiamina, niacina y riboflavina.</p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="https://katie-farris.com/images/Chicken/How-Long-Does-It-Take-to-Smoke-a-Whole-Chicken_11266.jpg" class="card-img-top" alt="Biotecnologia">
                    <div class="card-body">
                        <h5 class="card-title">Pollo ahumado</h5>
                        <p class="card-text">El pollo es rico en vitaminas de los grupos B, C, PP, colina, potasio, sodio, magnesio, azufre, fósforo, hierro. Estas sustancias ayudan a mejorar el funcionamiento del músculo cardíaco y tienen un efecto diurético. La carne de pollo es un producto indispensable en muchas dietas, ya que no contiene muchas calorías y satura perfectamente el organismo.</p>
                    </div>
                </div>
            </div>
        </div>
        <br>
</center>
        <div class="row">
            <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="true">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="3" aria-label="Slide 4"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="4" aria-label="Slide 5"></button>
                    </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="https://buenprovecho.hn/wp-content/uploads/2019/03/iStock-40-1.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://s1.eestatic.com/2020/10/20/cocinillas/recetas/aperitivos-y-entrantes/patatas-recetas_para_horno-aperitivos_y_entrantes_529708667_163064285_1024x576.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://thefoodtech.com/wp-content/uploads/2021/01/pepperoni-a-base-de-plantas-field-roast.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://curiosfera-recetas.com/wp-content/uploads/2021/01/Queso-Mozzarella.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://www.recetas-italia.com/base/stock/Post/41-image/41-image_web.jpg" class="d-block w-100" alt="200" >
                    </div>      
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
    </div>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.5/dist/umd/popper.min.js" integrity="sha384-Xe+8cL9oJa6tN/veChSP7q+mnSPaj5Bcu9mPX5F5xIGE0DVittaqT5lorf0EI7Vk" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js" integrity="sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy" crossorigin="anonymous"></script>


 <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
    <div class="row" style="color:#009999; padding:20px;">
    
 <div class="col" style="padding:5px;"> </div>
    <title>Document</title>
    <body bgcolor="#003333" style="Times New Roman: 'Times New Roman'; text-align: justify:">
</head>

    <nav class="navbar navbar-dark bg-light ">
        <div class="container-fluid text-dark">
            <a class="navbar-brand" href="#">
            <img src="Logo CVO.png" alt="" width="30" height="24" class="d-inline-block align-text-top">
            <span class="text-dark">Verduras</span>
        </a>
  </div>
    </nav>
    <h1 class="display-1 text-center"> Verduras </h1>
    <br>
    <center>
    <div class="container">
        <div class="row">
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="https://mejorconsalud.as.com/wp-content/uploads/2020/09/tomates.jpg" class="card-img-top" alt="Robotica">
                    <div class="card-body">
                        <h5 class="card-title">Tomate</h5>
                        <p class="card-text">El consumo de tomates también está asociado a la reducción del riesgo de enfermedades crónicas no transmisibles como enfermedades cardiovasculares, hipertensión y obesidad.</p>

                        <p class="card-text">Por último, también son buenos para la piel, ya que nos ayuda a protegernos de las quemaduras del sol.
                        </p>
                         </div>
                </div>
            </div>
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="https://mejorconsalud.as.com/wp-content/uploads/2015/08/comer-muchas-zanahorias-2048x1365.jpg" class="card-img-top" alt="Impresion 3D">
                    <div class="card-body">
                        <h5 class="card-title">Zanahoria</h5>
                        <p class="card-text">Es rica en fósforo, el cual vigoriza las mentes y cuerpos cansados. Es muy útil para eliminar los cólicos y favorece la digestión. Es un vegetal diurético que evita la retención de líquidos.</p>

                        <p class="card-text">
                        No puede faltar en verano, ya que facilita el bronceado de manera saludable y totalmente natural.
                        </p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="https://cloudfront-eu-central-1.images.arcpublishing.com/prisaradio/TVKXPVGS7JJY7C5D76DLOLCHU4.jpg" class="card-img-top" alt="Biotecnologia">
                    <div class="card-body">
                        <h5 class="card-title">Cebolla</h5>
                        <p class="card-text">Esta hortaliza ayuda a aliviar y combatir enfermedades respiratorias y cardiovasculares, así como también mejora la circulación sanguínea.</p>

                        <p class="card-text">Para resfriados o gripes, para la bajada de la tensión, o incluso como remedios caseros de belleza, ¡la cebolla es un imprescindible en nuestra despensa! 
                        </p>
                    </div>
                </div>
            </div>
        </div>
</center>
<br>    
<div class="row">
            <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="true">
                <div class="carousel-indicators">
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="3" aria-label="Slide 4"></button>
                    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="4" aria-label="Slide 5"></button>
                    </div>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img src="https://mejorconsalud.as.com/wp-content/uploads/2015/06/brocoli-ramas.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://s1.eestatic.com/2020/10/20/cocinillas/recetas/aperitivos-y-entrantes/patatas-recetas_para_horno-aperitivos_y_entrantes_529708667_163064285_1024x576.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://thefoodtech.com/wp-content/uploads/2021/01/pepperoni-a-base-de-plantas-field-roast.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://curiosfera-recetas.com/wp-content/uploads/2021/01/Queso-Mozzarella.jpg" class="d-block w-100" alt="200">
                    </div>
                    <div class="carousel-item">
                        <img src="https://www.recetas-italia.com/base/stock/Post/41-image/41-image_web.jpg" class="d-block w-100" alt="200" >
                    </div>      
                </div>
                <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Previous</span>
                </button>
                <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="visually-hidden">Next</span>
                </button>
            </div>
        </div>
    </div>
</body>
</html>