﻿<!doctype html>
<html class="no-js" lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>srtdash - SEO Dashboard</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" type="image/png" href="~/Content/assets/images/icon/favicon.ico">
    <link rel="stylesheet" href="~/Content/assets/css/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/assets/css/font-awesome.min.css">
    <link rel="stylesheet" href="~/Content/assets/css/themify-icons.css">
    <link rel="stylesheet" href="~/Content/assets/css/metisMenu.css">
    <link rel="stylesheet" href="~/Content/assets/css/owl.carousel.min.css">
    <link rel="stylesheet" href="~/Content/assets/css/slicknav.min.css">
    <!-- amchart css -->
    <link rel="stylesheet" href="https://www.amcharts.com/lib/3/plugins/export/export.css" type="text/css" media="all" />
    <!-- others css -->
    <link rel="stylesheet" href="~/Content/assets/css/typography.css">
    <link rel="stylesheet" href="~/Content/assets/css/default-css.css">
    <link rel="stylesheet" href="~/Content/assets/css/styles.css">
    <link rel="stylesheet" href="~/Content/assets/css/responsive.css">
    <!-- modernizr css -->
    <script src="~/Content/assets/js/vendor/modernizr-2.8.3.min.js"></script>
</head>

<body>
    <!--[if lt IE 8]>
            <p class="browserupgrade">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
        <![endif]-->
    <!-- preloader area start -->
    <div id="preloader">
        <div class="loader"></div>
    </div>
    <!-- preloader area end -->
    <!-- page container area start -->
    <div class="page-container">
        <!-- sidebar menu area start -->
        @Html.Partial("Nav")
        <!-- sidebar menu area end -->
        <!-- main content area start -->
        <div class="main-content">
            <!-- header area start -->
            <!-- header area end -->
            <!-- page title area start -->
        @RenderBody()
           
            <!-- page title area end -->
        </div>
        <!-- main content area end -->
        <!-- footer area start-->
        <footer>
            <div class="footer-area">
                <p>© Copyright 2018. All right reserved. Template by <a href="https://colorlib.com/wp/">Colorlib</a>.</p>
            </div>
        </footer>
        <!-- footer area end-->
    </div>
    <!-- page container area end -->
    <!-- offset area start -->

    <!-- offset area end -->
    <!-- jquery latest version -->
    <script src="~/Content/assets/js/vendor/jquery-2.2.4.min.js"></script>
    <!-- bootstrap 4 js -->
    <script src="~/Content/assets/js/popper.min.js"></script>
    <script src="~/Content/assets/js/bootstrap.min.js"></script>
    <script src="~/Content/assets/js/owl.carousel.min.js"></script>
    <script src="~/Content/assets/js/metisMenu.min.js"></script>
    <script src="~/Content/assets/js/jquery.slimscroll.min.js"></script>
    <script src="~/Content/assets/js/jquery.slicknav.min.js"></script>

    <!-- start chart js -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.min.js"></script>
    <!-- start highcharts js -->
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/export-data.js"></script>
    <!-- start amcharts -->
    <script src="https://www.amcharts.com/lib/3/amcharts.js"></script>
    <script src="https://www.amcharts.com/lib/3/ammap.js"></script>
    <script src="https://www.amcharts.com/lib/3/maps/js/worldLow.js"></script>
    <script src="https://www.amcharts.com/lib/3/serial.js"></script>
    <script src="https://www.amcharts.com/lib/3/plugins/export/export.min.js"></script>
    <script src="https://www.amcharts.com/lib/3/themes/light.js"></script>
    <!-- all line chart activation -->
    <script src="~/Content/assets/js/line-chart.js"></script>
    <!-- all pie chart -->
    <script src="~/Content/assets/js/pie-chart.js"></script>
    <!-- all bar chart -->
    <script src="~/Content/assets/js/bar-chart.js"></script>
    <!-- all map chart -->
    <script src="~/Content/assets/js/maps.js"></script>
    <!-- others plugins -->
    <script src="~/Content/assets/js/plugins.js"></script>
    <script src="~/Content/assets/js/scripts.js"></script>
</body>

</html>

