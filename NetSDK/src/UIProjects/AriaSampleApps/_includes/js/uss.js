var currently_opened = "";
var msgSaveOrNot = "You have made changes to the information. Would you like to save the changes?";

function openEditor(name) {
    //hideItem('msg_ChangesSaved');	
    hideItem("info_section_display_" + name);
    hideItem("info_section_edit_link_"+name);
    showItem("info_section_editor_" + name); 
    showItem("info_section_edit_link1_" + name);
    showItem("info_section_submit_link_"+name);
    currently_opened = name;
}

function closeEditor(name) {
    //hideItem("info_section_editor_" + currently_opened); 
    hideItem("info_section_editor_" + name); 
    hideItem("info_section_submit_link_" + name); 
    //hideItem("info_section_submit_link_" + currently_opened); 
    showItem("info_section_edit_link_"+name);
    //showItem("info_section_edit_link_"+currently_opened);
    //showItem("info_section_display_" + currently_opened);
    showItem("info_section_display_" + name);
    //hideItem("info_section_edit_link1_" + currently_opened);
    hideItem("info_section_edit_link1_" + name);
    currently_opened = "";			
}

function toggleTabs(id) {
      document.getElementById("tab1_tab").className = document.getElementById("tab1_tab").className.replace('active-tab','');
		  document.getElementById("tab1").className = document.getElementById("tab1").className.replace('active-tab-body','');
		  document.getElementById("tab2_tab").className = document.getElementById("tab2_tab").className.replace('active-tab','');
		  document.getElementById("tab2").className = document.getElementById("tab2").className.replace('active-tab-body','');
		  document.getElementById("tab3_tab").className = document.getElementById("tab3_tab").className.replace('active-tab','');
		  document.getElementById("tab3").className = document.getElementById("tab3").className.replace('active-tab-body','');
		  document.getElementById("tab5_tab").className = document.getElementById("tab5_tab").className.replace('active-tab','');
		  document.getElementById("tab5").className = document.getElementById("tab5").className.replace('active-tab-body','');
  	
		  document.getElementById(id + "_tab").className += " active-tab";
		  document.getElementById(id).className += " active-tab-body";
}

function fillBillInfo( checkboxObj )
{
    if (checkboxObj.checked)
    {
        $('bill_address1').value = $F('street1');
        $('bill_address2').value = $F('street2');
        $('bill_city').value = $F('city');
        $('bill_country').value = $F('country');
        countryChanged($('bill_state'),$('bill_country'));
        $('bill_state').value = $F('state');
        $('bill_zip').value = $F('zip_code');
    }
    else
    {
        $('bill_address1').value = "";
        $('bill_address2').value = "";
        $('bill_city').value = "";
        $('bill_country').value = "";
        $('bill_state').value = "";
        $('bill_zip').value = "";
    }
}

function show21(id)  
  {  
       if (document.getElementById(id).style.display == 'none')  
       {  
            document.getElementById(id).style.display = '';  
       }  
  }  
  //-->  
    
  <!--  
  function hide21(id)  
  {  
    if (document.getElementById(id) != null)
    {
      document.getElementById(id).style.display = 'none';
    }
  } 
  function emptyField(id)
  {
    document.getElementById(id).value = '';
  } 
 /*
 * Fabtabulous! Simple tabs using Prototype
 * http://tetlaw.id.au/view/blog/fabtabulous-simple-tabs-using-prototype/
 * Andrew Tetlaw
 * version 2 2008-08-10
 * http://creativecommons.org/licenses/by-sa/2.5/
 */
var Fabtabs = Class.create({
	initialize : function(element,options) {
		var parent = this.element = $(element);
		this.options = Object.extend({
		  hover: true,
		  remotehover: false,
		  anchorpolicy: 'allow' // 'protect', 'allow', 'allow initial', 'disable'
		}, options || {});
		this.menu = this.element.select('a');
		this.hrefs = this.menu.map(function(elm){
		  return elm.href.match(/#(\w.+)/) ? RegExp.$1 : null;
		}).compact();
		//this.on(this.getInitialTab());
		var onLocal = function(event) {
		  if(this.options.anchorpolicy !== 'allow'){ event.stop(); }
  		var elm = event.findElement("a");
  		this.activate(elm);
  		if(this.options.anchorpolicy === 'protect') { window.location.hash = '.'+this.tabID(elm); }
  	};
  	var onRemote = function(event) {
  	  if(this.options.anchorpolicy !== 'allow'){ event.stop(); }
	    var trig = event.findElement("a");
    	this.activate(this.tabID(trig));
    	if(this.options.anchorpolicy === 'protect') { window.location.hash = '.'+this.tabID(elm); }
	  }
		this.element.observe('click', onLocal.bindAsEventListener(this));
//		if(this.options.hover) {
//		  this.menu.each(function(elm){elm.observe('mouseover', //onLocal.bindAsEventListener(this))}.bind(this));
//		}
		var triggers = []; 
		this.hrefs.each(function(id){
		  $$('a[href="#' + id + '"]').reject(function(elm){
		    return elm.descendantOf(parent)
		  }).each(function(trig){
		    triggers.push(trig);
		  });
		})
		triggers.each(function(elm){
		  elm.observe('click', onRemote.bindAsEventListener(this));
		  if(this.options.remotehover) {
  		  elm.observe('mouseover', onRemote.bindAsEventListener(this));
  		}
		}.bind(this));
	},
	activate: function(elm) {
	  if(typeof elm == 'string') {
	    elm = this.element.select('a[href="#'+ elm +'"]')[0];
	  }
	  this.on(elm);
		this.menu.without(elm).each(this.off.bind(this));
	},
	off: function(elm) {
		$(elm).removeClassName('active-tab');
		$(this.tabID(elm)).removeClassName('active-tab-body');
	},
	on: function(elm) {
		$(elm).addClassName('active-tab');
		$(this.tabID(elm)).addClassName('active-tab-body');
	},
	tabID: function(elm) {
		return elm.href.match(this.re)[1];
	},
	getInitialTab: function() {
		if(this.options.anchorpolicy !== 'disable' && document.location.href.match(this.re)) {
		  var hash = RegExp.$1;
		  if(hash.substring(0,1) == "."){
		    hash = hash.substring(1);
		  }
		  return this.element.select('a[href="#'+ hash +'"]')[0];
		} else {
		  return this.menu.first();
		}
	},
	re: /#(\.?\w.+)/
});

document.observe("dom:loaded", function(){ new Fabtabs('tabs'); });

