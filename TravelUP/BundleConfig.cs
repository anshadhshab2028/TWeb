using System.Web.Optimization;

namespace TravelUP
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/bootstrapcssnetdna").Include(
                      "~/Content/bootstrap_netdna.min.css"));

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss1").Include(
                          "~/Content/lib/bootstrap/bootstrap_checkedlist.min.css"));

            bundles.Add(new StyleBundle("~/bundles/bootstrapcss").Include(
                          "~/Content/lib/bootstrap/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/bundles/fontcss").Include(
                          "~/fonts/font-awesome/css/font-awesome.min.css",
                          "~/fonts/themify-icons/themify-icons.css",
                          "~/Content/animate.css",
                          "~/Content/spinners.css"));

            bundles.Add(new StyleBundle("~/bundles/styles").Include(
                          "~/Content/helper.css",
                          "~/Content/style.css"));

            bundles.Add(new StyleBundle("~/bundles/select2css").Include(
                    "~/Content/lib/select2/css/select2.min.css"));

            bundles.Add(new StyleBundle("~/bundles/alertcss").Include(
                      "~/Content/lib/sweetalert/sweetalert.css"));

            bundles.Add(new StyleBundle("~/bundles/calendercss").Include(
                          "~/Content/lib/calendar2/semantic.ui.min.css",
                          "~/Content/lib/calendar2/pignose.calendar.min.css"));

            bundles.Add(new StyleBundle("~/bundles/tagscss").Include(
                          "~/Content/lib/owl.carousel.min.css",
                          "~/Content/lib/owl.theme.default.min.css"));


            bundles.Add(new StyleBundle("~/bundles/datatable").Include(
                          "~/Content/lib/data-table/jquery.dataTables.min.css",
                          "~/Content/lib/data-table/select.dataTables.min.css"));

            bundles.Add(new StyleBundle("~/bundles/daterangecss").Include(
                          "~/Content/lib/daterange/daterangepicker.css",
                          "~/Content/lib/air-datepicker/datepicker.css"));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                            "~/Scripts/lib/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                          "~/Scripts/lib/bootstrap/js/popper.min.js",
                          "~/Scripts/lib/bootstrap/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                          "~/Scripts/scripts.js"));

            bundles.Add(new ScriptBundle("~/bundles/alert").Include(
                          "~/Scripts/lib/sweetalert/sweetalert.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sidebarmenu").Include(
                          "~/Scripts/lib/sidemenu/jquery.slimscroll.js",
                          "~/Scripts/lib/sticky-kit-master/dist/sticky-kit.min.js",
                          "~/Scripts/lib/sidemenu/sidebarmenu.js"));

            bundles.Add(new ScriptBundle("~/bundles/charts").Include(
                          "~/Scripts/lib/morris-chart/raphael-min.js",
                          "~/Scripts/lib/morris-chart/morris.js",
                          "~/Scripts/lib/morris-chart/morris-init.js",
                          "~/Scripts/lib/echart/echarts.js",
                          "~/Scripts/lib/chart-js/Chart.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/calender").Include(
                          "~/Scripts/lib/calendar-2/moment.latest.min.js",
                          "~/Scripts/lib/calendar-2/prism.min.js",
                          "~/Scripts/lib/calendar-2/pignose.calendar.min.js",
                          "~/Scripts/lib/calendar-2/pignose.init.js"));

            bundles.Add(new ScriptBundle("~/bundles/tags").Include(
                          "~/Scripts/lib/owl-carousel/owl.carousel.min.js",
                          "~/Scripts/lib/owl-carousel/owl.carousel-init.js"));

            bundles.Add(new ScriptBundle("~/bundles/select2js").Include(
                          "~/Content/lib/select2/js/select2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                          "~/Scripts/lib/datatables/datatables.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js",
                          "~/Scripts/lib/datatables/cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js",
                          "~/Scripts/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/pdfmake.min.js",
                          "~/Scripts/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/vfs_fonts.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.print.min.js",
                          "~/Scripts/lib/datatables/datatables-init.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables1").Include(
                          "~/Scripts/lib/datatables/datatables.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js",
                          "~/Scripts/lib/datatables/cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js",
                          "~/Scripts/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/pdfmake.min.js",
                          "~/Scripts/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/vfs_fonts.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.print.min.js",
                          "~/Scripts/lib/datatables/datatables1-init.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables2").Include(
                          "~/Scripts/lib/datatables/datatables.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js",
                          "~/Scripts/lib/datatables/cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js",
                          "~/Scripts/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/pdfmake.min.js",
                          "~/Scripts/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/vfs_fonts.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js",
                          "~/Scripts/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.print.min.js",
                          "~/Scripts/lib/datatables/datatables2-init.js"));

            bundles.Add(new ScriptBundle("~/bundles/selectdatatables").Include(
                          "~/Scripts/lib/datatables/jquery-3.3.1.js",
                          "~/Scripts/lib/datatables/jquery.dataTables.min.js",
                          "~/Scripts/lib/datatables/dataTables.select.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/daterange").Include(
                          "~/Scripts/lib/daterange/daterangepicker.js",
                          "~/Scripts/lib/air-datepicker/datepicker.js",
                          "~/Scripts/lib/air-datepicker/i18n/datepicker.en.js"
                          ));

            bundles.Add(new ScriptBundle("~/Content/DropZoneJS").Include(
                "~/Scripts/lib/dropzone/dropzone.js"));


            bundles.Add(new StyleBundle("~/Content/DropZoneCss").Include(
                 "~/Content/lib/dropzone/dropzone.css"));

            bundles.Add(new StyleBundle("~/bundles/loginhelpercss").Include(
                      "~/Content/helper.css",
                      "~/Content/style.css",
                      "~/Content/imgclass.css"
                        ));

            bundles.Add(new StyleBundle("~/bundles/logincss").Include(
              "~/Content/login.css"
              ));

            bundles.Add(new StyleBundle("~/bundles/newstyle").Include(
              "~/Content/newstyle.css"));


            bundles.Add(new ScriptBundle("~/bundles/newscript").Include(
                          "~/Scripts/newscript.js"
                          ));
        }
    }
}
