
function remove_incomplete_run(data){
	return data.filter(function(data1){
		return !data1.injured;
	});
	
}

function getKey(arr,key){
	return arr.map(function(z){return z[key];});
}
function run_by_date(data){
	var finishedRuns=remove_incomplete_run(data);
	return{
		x : getKey(finishedRuns,'date'),
		y : getKey(finishedRuns,'time')
		
	};
	
}

function run_by_bmi(data){
	var finishedRuns=remove_incomplete_run(data);
	return{
		x : getKey(finishedRuns,'bmi'),
		y : getKey(finishedRuns,'time')
		
	};
	
}



function recent_Runs(data){
	var recent = 28;
  var dates = data.map(function(temp){return new Date(temp.date);});
  
  return dates.map(function(run_date,run_idx){
    var oldest= new Date(run_date);
    oldest.setDate(oldest.getDate()-recent);
    var i = run_idx - 1;
    while(i >= 0 && dates[i] >= oldest) i--;
    i++;
    return run_idx - i;
  });
}
/*



*/
function calculate_injury_probability_by_recent_run_number(runs){
  //For each run, calculate how many recent runs the user took
  var recent_run_counts = recent_Runs(runs);
  //Calculate the range of recent runs
  var max_recent_runs = recent_run_counts.reduce(function(acc,run_count){
      return Math.max(acc,run_count);
    },0
  );
  var recent_run_range = [];
  var recent_run_count_and_injury_frequency = [];
  for(var i = 0;i<=max_recent_runs;i++){
    recent_run_range.push(i);
    recent_run_count_and_injury_frequency.push({count:0,injuries:0});
  }
  //For each possible recent run value, calculate the observed injury
  //probability
  var injury_probs = runs.reduce(function(acc,run,run_idx){
    acc[recent_run_counts[run_idx]].count++;
      if(run.injured) acc[recent_run_counts[run_idx]].injuries++;
      return acc;
    },
    recent_run_count_and_injury_frequency
  ).map(function(d){return d.injuries/d.count;});

  return {
    x : recent_run_range,
    y : injury_probs
  };
}
	