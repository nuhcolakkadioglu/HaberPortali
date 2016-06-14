function KategoriEkle()
{
    Kategori = new Object();

    Kategori.KategoriAdi = $('#KategoriAdi').val();
    Kategori.Url = $('#Url').val();
    Kategori.IsActive = $('#IsActive').is(":checked");

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