import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardHeader from '@material-ui/core/CardHeader';
import CardMedia from '@material-ui/core/CardMedia';
import CardContent from '@material-ui/core/CardContent';
import CardActions from '@material-ui/core/CardActions';
import IconButton from '@material-ui/core/IconButton';
import Typography from '@material-ui/core/Typography';
import { red } from '@material-ui/core/colors';
import WishlistIcon from '../../../../assets/images/original/Contoso_Assets/Icons/wishlist_icon.svg'

const useStyles = makeStyles((theme) => ({
  root: {
    maxWidth: 345,
  },
  media: {
    height: 0,
    paddingTop: '56.25%', // 16:9
  },
  expand: {
    transform: 'rotate(0deg)',
    marginLeft: 'auto',
    transition: theme.transitions.create('transform', {
      duration: theme.transitions.duration.shortest,
    }),
  },
  expandOpen: {
    transform: 'rotate(180deg)',
  },
  avatar: {
    backgroundColor: red[500],
  },
}));

export default function Product({prodImg}) {
  const classes = useStyles();

  return (
    <Card className="productCard">
      <CardHeader/>
      <CardMedia
        className={classes.media}
        image={prodImg}
        title="Paella dish"
      />
      <CardContent>
        <div style={{display:'flex',alignItems:'center'}}>
            <Typography variant="h6" color="initial" component="h6" style={{marginRight:'auto'}}>
                Lunar Shift Special Edition
            </Typography>
            <IconButton aria-label="add to favorites">
                {/* <FavoriteIcon /> */}
                <img src={WishlistIcon} alt="like"/>
            </IconButton>
        </div>
        <Typography variant="body2" color="textSecondary" component="p">
          Controller
        </Typography>
        <div style={{display:'flex',alignItems:'center',paddingTop:'10px'}}>
            <Typography variant="h6" color="initial" component="h6" style={{marginRight:'auto'}} className="m-0 mr-1">
                $39.49
            </Typography>
            <Typography paragraph color="textSecondary" className="m-0 mr-1">
                $78.46
            </Typography>
            <Typography paragraph color="error" className="m-0 mr-1 ">
                50% OFF
            </Typography>
        </div>
      </CardContent>
      <CardActions></CardActions>
    </Card>
  );
}