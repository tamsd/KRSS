#######################Script to generate pseudo-store folders in the format of 4 digits####################

#Adjustable paramters for script
$MAX_STORES = 10000;
$MAX_REGIONID = 9;
$MAX_INVOICEID = 1000000;
$MAX_CUSTOMERID = 10000000;
$MAX_DATEOFFSET = 2555;
$MAX_ARCHIVEFILES = 100;
$MAX_TEMPHOLDERFILES = 50;

#Prompt user for base folder to create test environment
echo "Enter the full path to where the test environment should be created:";
$user_root = Read-Host;

#Warn the user
$warning_msg = "WARNING: All the contents of " + $user_root + " will be deleted (including childrens' contents)!";
echo $warning_msg;
$response = 'x';
while($response -ne 'y' -and $response -ne 'n'){
    $response = Read-Host 'Would you like to continue? (y/n)';
}

#Create test folders and put test files in each
if($response -eq 'y'){
    #Clear the contents of the folder
    $clear_path = $user_root + "\*";
    Remove-Item $clear_path -Recurse;

    #create store folders
    for($i = 0; $i -lt $MAX_STORES; $i++){
        $store_id = $i;
        $new_folder = $user_root + "\stores\" + $store_id;
        New-item $new_folder -type directory;
    }

    #create archive folders
    $archives = $user_root + "\archives";
    New-Item $archives -type directory;
    $archive_1 = $archives + "\archive_1";
    $archive_2 = $archives + "\archive_2";
    New-Item $archive_1 -type directory;
    New-Item $archive_2 -type directory;

    #generate test files for archive folders
     for($i = 0; $i -lt $MAX_ARCHIVEFILES; $i++){
        $store_id = Get-Random -Minimum 0 -Maximum ($MAX_STORES);
        $region_id = Get-Random -Minimum 0 -Maximum ($MAX_REGIONID+1);
        $invoice_id = Get-Random -Minimum 0 -Maximum ($MAX_INVOICEID+1);
        $customer_id = Get-Random -Minimum 0 -Maximum ($MAX_CUSTOMERID+1);
        $date = Get-Date;
        $offset = Get-Random -Minimum 0 -Maximum ($MAX_DATEOFFSET+1);
        $date = $date.AddDays(-1*$offset);
        $file_name = $store_id.ToString()+"."+$region_id.ToString()+"."+$invoice_id.ToString()+"."+$customer_id.ToString()+"."+$date.ToString("MMddyyy")+".pdf";
        $r = Get-Random -Minimum 0 -Maximum 2;
        if($r -eq 0){
            $file_path = $archive_1+"\"+$file_name;
        }
        else{
            $file_path = $archive_2+"\"+$file_name;
        }
        $copy_dest = $user_root + "\stores\" + $store_id + "\" + $file_name;
        if(Test-Path $copy_dest){
            #file already exists in store folder
        }
        else{
            $copy_dest = $user_root + "\stores\" + $store_id;
            New-item $file_path -type file;
            Copy-Item $file_path $copy_dest;
        }
    }

    #create temporary holding folders
    $temp_holders = $user_root + "\temp_holders";
    New-Item $temp_holders -type directory;
    $temp_holder_1 = $temp_holders + "\temp_holder_1";
    $temp_holder_2 = $temp_holders + "\temp_holder_2";
    New-Item $temp_holder_1 -type directory;
    New-Item $temp_holder_2 -type directory;

    #generate test files for temp holders
    for($i = 0; $i -lt $MAX_TEMPHOLDERFILES; $i++){
        $store_id = Get-Random -Minimum 0 -Maximum ($MAX_STORES);
        $region_id = Get-Random -Minimum 0 -Maximum ($MAX_REGIONID+1);
        $invoice_id = Get-Random -Minimum 0 -Maximum ($MAX_INVOICEID+1);
        $customer_id = Get-Random -Minimum 0 -Maximum ($MAX_CUSTOMERID+1);
        $date = Get-Date;
        $offset = Get-Random -Minimum 0 -Maximum 15; #only files 14 days or younger in here
        $date = $date.AddDays(-1*$offset);
        $file_name = $store_id.ToString()+"."+$region_id.ToString()+"."+$invoice_id.ToString()+"."+$customer_id.ToString()+"."+$date.ToString("MMddyyy")+".pdf";
        $r = Get-Random -Minimum 0 -Maximum 2;
        if($r -eq 0){
            $file_path = $temp_holder_1+"\"+$file_name;
        }
        else{
            $file_path = $temp_holder_2+"\"+$file_name;
        }
        $copy_dest = $user_root + "\stores\" + $store_id + "\" + $file_name;
        if(Test-Path $copy_dest){
            #file already exists in store folder
        }
        else{
           # $copy_dest = $user_root + "\stores\" + $store_id;
            New-item $file_path -type file;
           # Copy-Item $file_path $copy_dest;
        }
    }

    echo "Finished creating test environment";
    Read-Host;
}
else{
    Write-Host "Good-Bye";
    Read-Host;
}