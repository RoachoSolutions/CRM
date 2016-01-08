$(document).ready(function () {
    $("#btnAgregarNota").click(function () {        
        var nota = $("#txtnota").val();
        var id = $("#id").val();
        $.ajax({
            url: urlbase + "Prospectos/Detalle/AgregarNota",
            method:"POST",
            data: {
                id: id,
                nota: nota
            },
            success: function (response, status, xhr) {                                
                try {
                    var datos = response;
                    if (typeof (response) !== "object") {
                        datos = JSON.parse(response);
                    }
                    
                    if (datos.status == 1) {
                        $("#divnotas .feed-element:first-child").after(datos.result);
                        $("#txtnota").val("");
                        toastr["success"]("Nota Agregada Exitosamente");                        
                    } else {
                        toastr["error"](datos.error);                        
                    }
                } catch (ex) {
                    toastr["error"](ex.message);
                }
            },
            error: function( jqXHR, textStatus, errorThrown ){
                alert(errorThrown);
            }
        });
    });

    $("#btnVerMasNota").click(function () {
        var id = $("#id").val();
        var idnota = $("#idnotalast").val();
        if (idnota == "-1")
            return;
        $.ajax({
            url: urlbase + "Prospectos/Detalle/ObtenerNotas",
            method: "GET",
            data: {
                id: id,
                idnota: idnota
            },
            success: function (response, status, xhr) {
                try {
                    debugger;
                    var datos = response;
                    if (typeof (response) !== "object") {
                        datos = JSON.parse(response);
                    }

                    if (datos.status == 1) {
                        $("#divnotas .feed-element:last-child").before(datos.result);
                        $("#txtnota").val("");
                        $("#idnotalast").val(datos.id);
                        location.hash = "#btnVerMasNota";
                        if (datos.id == "-1")
                            $("#btnVerMasNota").hide();
                    } else {
                        toastr["error"](datos.error);
                    }
                } catch (ex) {
                    toastr["error"](ex.message);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(errorThrown);
            }
        });
    });
});


function MostrarMasInfo() {
    $("#dvmore").toggle();
}