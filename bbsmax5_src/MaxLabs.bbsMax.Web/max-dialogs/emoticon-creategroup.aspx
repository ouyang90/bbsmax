﻿<!--[DialogMaster title="创建表情分组" width="400" ]-->
<!--[place id="body"]-->
<form action='$_form.action' method="post">
<!--[include src="_error_.ascx" /]-->
<div class="clearfix dialogbody">
    <div class="dialogform dialogform-horizontal">
        <div class="formrow">
            <h3 class="label"><label for="sortorder">排序</label></h3>
            <div class="form-enter">
                <input style="width:3em;" class="text" type="text" name="sortorder" id="sortorder" />
            </div>
        </div>
        <div class="formrow">
            <h3 class="label"><label for="groupname">名称</label></h3>
            <div class="form-enter">
                <input class="text" type="text" name="groupname" id="groupname" />
            </div>
            <div class="form-note">表情分组是以文件夹的形式存在, 因此名称不能包含以下字符: \ / : * ? " &lt; &gt; | </div>
        </div>
    </div>
</div>
<div class="clearfix dialogfoot">
    <button class="button button-highlight" type="submit" name="create" accesskey="y" title="确定"><span>确定(<u>Y</u>)</span></button>
    <button class="button" type="reset" accesskey="c" title="取消" onclick="panel.close();"><span>取消(<u>C</u>)</span></button>
</div>
</form>
<!--[/place]-->
<!--[/dialogmaster]-->