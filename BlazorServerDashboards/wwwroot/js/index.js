window.JsFunctions = {
    InitWebDashboard: function () {
        DevExpress.Dashboard.ResourceManager.embedBundledResources();
        this.dashboardControl = new DevExpress.Dashboard.DashboardControl(document.getElementById("web-dashboard"), {
            endpoint: "/api/dashboard"
        });
        this.dashboardControl.registerExtension(new DevExpress.Dashboard.DashboardPanelExtension(this.dashboardControl));
        this.dashboardControl.render();
    },
    DisposeWebDashboard: function () {
        this.dashboardControl.dispose();
    }
};