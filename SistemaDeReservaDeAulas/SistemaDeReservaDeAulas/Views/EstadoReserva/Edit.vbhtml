﻿
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Sistema de Reservas de Aula</title>
    <link href="~/scripts/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>

    <div class="container-fluid">

        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="/">Sistema de Reservas de Aulas</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    @*<li class="nav-item active">
                            <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Link</a>
                        </li>*@
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Mantener
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <a class="dropdown-item" href="/EstadoReserva">Estados de Reserva</a>
                            @*<a class="dropdown-item" href="#">Another action</a>*@
                            @*<div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#">Something else here</a>*@
                        </div>
                    </li>
                    @*<li class="nav-item">
                            <a class="nav-link disabled" href="#">Disabled</a>
                        </li>*@
                </ul>
                @*<form class="form-inline my-2 my-lg-0">
                        <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search">
                        <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
                    </form>*@
            </div>
        </nav>

    </div>

    <div class="container">
        <h3>Modificar estado de Reserva</h3>
        <form action="/EstadoReserva/Edit" method="post">
            <input type="hidden" name="txtId_estado_reserva" value="@Model.pId_estado_reserva" />
            <div class="form-group">
                <label class="form">Descripción:</label>
                <input class="form-control col-md-4" type="text" name="txtDescripcion" value="@Model.pDescripcion" placeholder="Descripcion" required />
            </div>

            <div class="form-group">
                <input type="submit" class="btn btn-primary" value="Guardar">
                <input type="reset" class="btn btn-default" value="Cancelar">
            </div>

        </form>
    </div>

    <script src="~/scripts/js/jquery-3.3.1.min.js"></script>
    <script src="~/scripts/js/bootstrap.min.js"></script>
</body>
</html>
