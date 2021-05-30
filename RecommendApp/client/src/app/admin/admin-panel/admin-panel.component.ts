import { Component, OnInit } from '@angular/core';
import { AdminData } from 'src/app/_models/adminData';
import { AdminService } from 'src/app/_services/admin.service';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import * as pluginDataLabels from 'chartjs-plugin-datalabels';
import { Label } from 'ng2-charts';
import { AmigosPorEstado } from 'src/app/_models/amigosPorEstado';


@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css']
})
export class AdminPanelComponent implements OnInit {

  adminData:AdminData;

  public barChartOptions: ChartOptions = {
    responsive: true,
    // We use these empty structures as placeholders for dynamic theming.
    scales: { xAxes: [{}], yAxes: [{}] },
    plugins: {
      datalabels: {
        anchor: 'end',
        align: 'end',
      }
    }
  };
  
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [pluginDataLabels];

  public barChartLabels: Label[] ;
  public barChartData: ChartDataSets[] = [{ data: [0, 0, 0, 0], label: 'Amigos' }];


  constructor(private adminService: AdminService) { }

  ngOnInit(): void {
    this.getAdminData();

   
  }



  getAdminData(){
    this.adminService.getAdminData().subscribe(response => {
      this.adminData = response;
      console.log(response);

      this.barChartLabels = this.adminData.amigosPorEstado;
      this.barChartData =  [{ data: this.adminData.qtAmigos, label: 'Amigos' }] ;
    })
  }

   // events
   public chartClicked({ event, active }: { event: MouseEvent, active: {}[] }): void {
    console.log(event, active);
  }

  public chartHovered({ event, active }: { event: MouseEvent, active: {}[] }): void {
    console.log(event, active);
  }

}
