@Code
    ViewData("Title") = "VideoToImageText"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>VideoToImageText</h2>

<form id="form1" class="forms-sample" enctype="multipart/form-data">
    <div class="form-group">
        <label>Video</label>
        <input type="file" class="form-control" name="video" accept=".mp4, .avi, .wmv, .mov, .flv, .mp3">
    </div>
</form>