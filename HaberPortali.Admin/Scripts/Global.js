function KategoriEkle()
{
    Kategori = new Object();

    Kategori.KategoriAdi = $('#KategoriAdi').val();
    Kategori.Url = $('#Url').val();
    Kategori.IsActive = $('#IsActive').is(":checked");
    Kategori.ParentID = $('#ParentID').val();

    $.ajax({

        url: '/Kategori/Ekle',
        data: Kategori,
        type: "POST",
        success:function(response)
        {
            if (response.Success)
                alert(response.Message);
            else
                alert(response.Message);
        }

    });

}

function KateGoriSil(id)
{
    
    $.ajax({

        url: "/Kategori/Sil/" + id,
        type: "POST",
        dataType: "json",
        success: function (response)
        {
            if (response.Success)
            {

                alert(response.Message);
                location.reload()
            }
            else
                alert(response.Message);
        }

    });

}