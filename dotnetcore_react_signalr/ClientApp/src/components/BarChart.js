import React, { useEffect } from 'react'
import * as d3 from 'd3'
const BarChart = (props) => {
    const canvasHeight = 350
    const canvasWidth = window.innerWidth
    const scale = 5
    const data = props.usersPoints    
    
    useEffect(() => {
        drawBarChart(data)
    }, []);    

    useEffect(() => {        
        updateBarChartMerge(data)
    }, [data]);    

    function drawBarChart(data) {
        const canvas = d3.select("#canvas")
            .append("svg")
            .attr("width", canvasWidth)
            .attr("height", canvasHeight)
            .style("border", "1px solid black")
            .style("overview-x", "auto")
    };

    function updateBarChartMerge(data) {
        const svg = d3.select("#canvas svg")

        var rect = svg.selectAll("rect")
            .data(data);

        rect.enter()
            .append("rect")
            .merge(rect)
            .attr("width", 70)
            .attr("fill", "orange")
            .attr("x", (datapoint, iteration) => iteration * 80 + 30)
            .transition()
            .delay(100)
            .duration(800)
            .attr("height", (datapoint) => datapoint.points * scale + 1)
            .attr("y", (datapoint) => canvasHeight - datapoint.points * scale - 40)

        var points = svg.selectAll("text.points")
            .data(data);

        points.enter()
            .append("text")
            .merge(points)
            .attr("class", "points")
            .attr("x", (datapoint, iteration) => iteration * 80 + 60)
            .text(datapoint => datapoint.points)
            .transition()
            .delay(100)
            .duration(800)
            .attr("y", (datapoint, iteration) => canvasHeight - datapoint.points * scale - 50)

        var names = svg.selectAll("text.name")
            .data(data);

        names.enter()
            .append("text")
            .merge(names)
            .attr("class", "name")
            .attr("x", (datapoint, iteration) => iteration * 80 + 30)
            .attr("y", (datapoint, iteration) => canvasHeight - 20)
            .attr("font-size", "small")
            .text(datapoint => datapoint.name)
    }
    
    return (<div id="canvas"></div>)
}
export default BarChart